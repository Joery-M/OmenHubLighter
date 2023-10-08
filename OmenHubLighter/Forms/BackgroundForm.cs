using Hp.Ohl.WmiService.Models;
using Microsoft.Win32.TaskScheduler;
using OmenHubLighter.Properties;
using System.Diagnostics;
using WindowsInput;
using WindowsInput.Events;

namespace OmenHubLighter.Forms
{
    public partial class BackgroundForm : Form
    {

        private FormNotify formNotify = new();
        private FormPopup popup = new();
        public BackgroundForm()
        {
            InitializeComponent();
            Visible = false;

            Shown += (sender, e) =>
            {
                Hide();
                ShowInTaskbar = false;
            };

            TaskbarQuit.Click += (sender, e) =>
            {
                Program.Quit();
            };
            TaskbarChangeOmenKey.Click += (sender, e) =>
            {
                var hotkey = new FormHotkey();
                hotkey.Show();
            };

            TaskbarRunOnStartup.Checked = Settings.Default.RunAtStartup;

            TaskbarRunOnStartup.CheckedChanged += (sender, e) =>
            {
                Settings.Default.RunAtStartup = TaskbarRunOnStartup.Checked;
                Settings.Default.Save();
            };

            Settings.Default.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(Settings.Default.RunAtStartup))
                {
                    TaskbarRunOnStartup.Checked = Settings.Default.RunAtStartup;
                    SetRunOnStartup(Settings.Default.RunAtStartup);
                };
            };
        }

        public async void WmiEventWatcher_HpBiosEventArrived(object sender, HpBiosEventArgs e)
        {
            if (e.eventPayload is OmenKeyPressedPayload)
            {
                try
                {
                    if (Settings.Default.UseOmenAlternateKey)
                    {
                        string modifiers = "";
                        Keys key = Settings.Default.AlternateKey;
                        Keys noModifiersKey = ((Keys)((int)key & ~-65536));

                        bool hasCtrl = key.HasFlag(Keys.Control);
                        bool hasShift = key.HasFlag(Keys.Shift);
                        bool hasAlt = key.HasFlag(Keys.Alt);

                        List<KeyCode> keysToPress = new();

                        if (hasCtrl)
                            keysToPress.Add(KeyCode.Control);
                        if (hasShift)
                            keysToPress.Add(KeyCode.Shift);
                        if (hasAlt)
                            keysToPress.Add(KeyCode.Alt);

                        keysToPress.Add((KeyCode)noModifiersKey);
                        await Simulate.Events()
                            .ClickChord(keysToPress).Wait(10)
                            .Invoke();
                    }
                    else if (Settings.Default.UseOmenKeyExecute)
                    {
                        Process p = new Process();
                        ProcessStartInfo pi = new ProcessStartInfo();
                        pi.UseShellExecute = true;
                        pi.FileName = Settings.Default.ExecutePath;
                        pi.Arguments = Settings.Default.ExecuteArguments;
                        p.StartInfo = pi;
                        try
                        {
                            p.Start();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }
                    }
                    else
                    {
                        Invoke(popup.OmenKeyPressed);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            else if (e.eventPayload is WinKeyLockPayload WinkeyPayload)
            {
                Invoke(formNotify.Notify, ButtonType.Winkey, WinkeyPayload.IsWinKeyEnabled);
            }
            else if (e.eventPayload is TouchPadTogglePayload TouchpadPayload)
            {
                Invoke(formNotify.Notify, ButtonType.Trackpad, TouchpadPayload.IsTouchPadEnabled);
            }
        }

        private void TaskbarNotifyIcon_Click(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Invoke(popup.OmenKeyPressed);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SetRunOnStartup(bool runOnStarup)
        {
            using (TaskService ts = new TaskService())
            {
                if (runOnStarup)
                {
                    var existingTasks = ts.RootFolder.Tasks.Where((a) => a.Name == "OmenHubLighterStartup");
                    if (existingTasks.Any())
                    {
                        ts.RootFolder.DeleteTask("OmenHubLighterStartup");
                    }
                    TaskDefinition td = ts.NewTask();

                    // Logged on or not with highest privileges 
                    td.Principal.LogonType = TaskLogonType.InteractiveToken;
                    td.Settings.ExecutionTimeLimit = TimeSpan.Zero;
                    td.Principal.RunLevel = TaskRunLevel.Highest;

                    td.RegistrationInfo.Description = $"Start OmenHubLighter";
                    td.Triggers.Add(new LogonTrigger());
                    td.Actions.Add(new ExecAction(Application.ExecutablePath));

                    ts.RootFolder.RegisterTaskDefinition($"OmenHubLighterStartup", td);
                }
                else
                {
                    var existingTasks = ts.RootFolder.Tasks.Where((a) => a.Name == "OmenHubLighterStartup");
                    if (existingTasks.Any())
                    {
                        ts.RootFolder.DeleteTask("OmenHubLighterStartup");
                    }
                }
            }
        }
    }
}
