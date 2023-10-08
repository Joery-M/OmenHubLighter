using Hp.Omen.OmenCommonLib;
using Hp.Omen.OmenCommonLib.PowerControl.Enum;
using OmenHubLight.Lib;
using OmenHubLighter.Properties;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace OmenHubLighter.Forms
{
    public partial class FormPopup : Form
    {
        private Button activeButton;
        private Timer focusTimer = new Timer();
        public bool AppIsExiting = false;
        private OmenHsaClient hsaClient = new();
        private Timer updateTextTimer = new Timer();

        public FormPopup()
        {
            InitializeComponent();
            //if (Settings.Settings != null)
            //{
            //ActivePerformanceModeChange((PerformanceMode)Settings.Default.PerformanceMode);
            //}

            focusTimer.Tick += delegate
            {
                if (ApplicationIsActivated())
                    focusTimer.Stop();
                else
                    Activate();
            };
            focusTimer.Interval = 10;
            updateTextTimer.Interval = 500;
            updateTextTimer.Tick += UpdateTempInfo;

            if(Settings.Default.fanOff || Settings.Default.fanMax)
            {
                ActivePerformanceModeChange(Settings.Default.fanMax, Settings.Default.fanOff);
            }else
            {
                ActivePerformanceModeChange(Settings.Default.PerformanceMode);
            }

            Settings.Default.PropertyChanged += Settings_PropertyChanged;
        }

        private void Settings_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PerformanceMode")
            {
                ActivePerformanceModeChange(Settings.Default.PerformanceMode);
            }
            else if (e.PropertyName == "fanMax" || e.PropertyName == "fanOff")
            {
                ActivePerformanceModeChange(Settings.Default.fanMax, Settings.Default.fanOff);
            }
        }

        public new void Show()
        {
            base.Show();
            focusTimer.Start();
            UpdateTempInfo(new object(), EventArgs.Empty);

            var screenBounds = (Screen.FromPoint(Cursor.Position) ?? Screen.PrimaryScreen).Bounds;
            var xPos = (screenBounds.Width / 2) - (Width / 2) + screenBounds.X;
            var yPos = (screenBounds.Height + screenBounds.Top) - (Height + 50);

            Location = new Point(xPos, yPos);

            if (activeButton != null)
            {
                activeButton.Focus();
                activeButton.Select();
            }
            updateTextTimer.Start();
        }
        public new void Hide()
        {
            if (focusTimer.Enabled)
                focusTimer.Stop();
            updateTextTimer.Stop();
            base.Hide();
        }
        public static bool ApplicationIsActivated()
        {
            var activatedHandle = GetForegroundWindow();
            if (activatedHandle == IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            var procId = Process.GetCurrentProcess().Id;
            int activeProcId;
            GetWindowThreadProcessId(activatedHandle, out activeProcId);

            return activeProcId == procId;
        }

        public event EventHandler<PerformanceMode> PerformanceModeChange;


        public void UpdateTempInfoText(float cpuTemperatures, float gpuTemperatures)
        {
            cpuTempLabel.Text = $"CPU: {cpuTemperatures}℃";
            gpuTempLabel.Text = $"GPU: {gpuTemperatures}℃";
        }
        private void QuietButton_Click(object sender, EventArgs e)
        {
            hsaClient.SetSwFanControlLevel(0, 0);
            hsaClient.SetMaxFan(MaxFanMode.Off);
            hsaClient.SetFanMode(PerformanceMode.Quiet);
            Settings.Default.fanMax = false;
            Settings.Default.fanOff = false;
            Settings.Default.PerformanceMode = PerformanceMode.Quiet;
            Settings.Default.Save();
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            hsaClient.SetSwFanControlLevel(0, 0);
            hsaClient.SetMaxFan(MaxFanMode.Off);
            hsaClient.SetFanMode(PerformanceMode.Default);
            Settings.Default.fanMax = false;
            Settings.Default.fanOff = false;
            Settings.Default.PerformanceMode = PerformanceMode.Default;
            Settings.Default.Save();
        }

        private void PerformanceButton_Click(object sender, EventArgs e)
        {
            hsaClient.SetSwFanControlLevel(0, 0);
            hsaClient.SetMaxFan(MaxFanMode.Off);
            hsaClient.SetFanMode(PerformanceMode.Performance);
            Settings.Default.fanMax = false;
            Settings.Default.fanOff = false;
            Settings.Default.PerformanceMode = PerformanceMode.Performance;
            Settings.Default.Save();
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("This will cause your temperatures to rise. Make sure your laptop does not overheat", "Be careful", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.OK)
            {
                hsaClient.SetMaxFan(MaxFanMode.Off);
                hsaClient.SetSwFanControlLevel(1, 1);
                Settings.Default.fanMax = false;
                Settings.Default.fanOff = true;
                Settings.Default.Save();
            }
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            hsaClient.SetFanMode(PerformanceMode.Performance);
            hsaClient.SetSwFanControlLevel(100, 100);
            Settings.Default.fanMax = true;
            Settings.Default.fanOff = false;
            Settings.Default.Save();
        }

        private readonly Color activeColor = Color.FromArgb(153, 153, 153);
        private readonly Color inactiveColor = Color.FromArgb(64, 64, 64);
        private readonly Color activeTextColor = Color.FromArgb(31, 31, 31);
        private readonly Color inactiveTextColor = Color.FromArgb(230, 230, 230);
        public void ActivePerformanceModeChange(bool isMax, bool isOff)
        {
            QuietButton.BackColor = inactiveColor;
            QuietButton.ForeColor = inactiveTextColor;
            DefaultButton.BackColor = inactiveColor;
            DefaultButton.ForeColor = inactiveTextColor;
            PerformanceButton.BackColor = inactiveColor;
            PerformanceButton.ForeColor = inactiveTextColor;
            OffButton.BackColor = inactiveColor;
            OffButton.ForeColor = inactiveTextColor;
            MaxButton.BackColor = inactiveColor;
            MaxButton.ForeColor = inactiveTextColor;
            activeButton = null;

            if (isMax)
            {
                MaxButton.BackColor = activeColor;
                MaxButton.ForeColor = activeTextColor;
                activeButton = MaxButton;
            }
            else if (isOff)
            {
                OffButton.BackColor = activeColor;
                OffButton.ForeColor = activeTextColor;
                activeButton = OffButton;
            }
        }
        public void ActivePerformanceModeChange(PerformanceMode m)
        {
            QuietButton.BackColor = inactiveColor;
            QuietButton.ForeColor = inactiveTextColor;
            DefaultButton.BackColor = inactiveColor;
            DefaultButton.ForeColor = inactiveTextColor;
            PerformanceButton.BackColor = inactiveColor;
            PerformanceButton.ForeColor = inactiveTextColor;
            OffButton.BackColor = inactiveColor;
            OffButton.ForeColor = inactiveTextColor;
            MaxButton.BackColor = inactiveColor;
            MaxButton.ForeColor = inactiveTextColor;
            activeButton = null;
            switch (m)
            {
                case PerformanceMode.Quiet:
                    QuietButton.BackColor = activeColor;
                    QuietButton.ForeColor = activeTextColor;
                    activeButton = QuietButton;
                    break;
                case PerformanceMode.Default:
                    DefaultButton.BackColor = activeColor;
                    DefaultButton.ForeColor = activeTextColor;
                    activeButton = DefaultButton;
                    break;
                case PerformanceMode.Performance:
                    PerformanceButton.BackColor = activeColor;
                    PerformanceButton.ForeColor = activeTextColor;
                    activeButton = PerformanceButton;
                    break;
            }
        }

        public void UpdateFanSpeedText(List<int> speeds)
        {
            List<string> fanSpeeds = new List<string>();
            for (int i = 0; i < speeds.Count; i++)
            {
                int value = speeds[i];
                fanSpeeds.Add($"Fan {i + 1}: {value}%");
            }
            fanList.Text = String.Join("\n", fanSpeeds);
        }

        private void FormPopup_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateTempInfo(object sender, EventArgs a)
        {
            Task.Run(() =>
            {
                List<int> levels = hsaClient.GetFanLevel().ConvertAll<int>((byte a) => (int)a);

                Invoke(UpdateFanSpeedText, levels);
            });


            Task.Run(() =>
            {
                if (AppIsExiting) return;
                foreach (var h in CpuInfo.GetCpuHardwares())
                {
                    h.Update();
                }

                foreach (var h in GpuInfo.GetGpuHardwares())
                {
                    h.Update();
                }

                var cpuTemperatures = CpuInfo.GetCpuHardwares()
                    .Select(x => x.GetTempSensors().Max(x => x.Value))
                    .Max() ?? 0f;
                var gpuTemperatures = GpuInfo.GetGpuHardwares()
                    .Select(x => x.GetTempSensors().Max(x => x.Value))
                    .Max() ?? 0f;

                Invoke(UpdateTempInfoText, cpuTemperatures, gpuTemperatures);
            });
        }

        public delegate void ShowFormDelegate();

        public void OmenKeyPressed()
        {
            if (Visible)
            {
                Hide();
            }
            else
            {
                List<int> levels = hsaClient.GetFanLevel().ConvertAll<int>((byte a) => (int)a);

                Show();
                Invoke(UpdateFanSpeedText, levels);
            };
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
    }
}
