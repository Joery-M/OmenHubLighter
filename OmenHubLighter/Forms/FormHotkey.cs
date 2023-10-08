using OmenHubLighter.Properties;
using System.Diagnostics;

namespace OmenHubLighter.Forms
{
    public partial class FormHotkey : Form
    {

        private bool isListening = false;
        private Keys selectedKey;
        public FormHotkey()
        {
            InitializeComponent();

            try
            {
                selectedKey = Settings.Default.AlternateKey;
            }
            catch (Exception)
            {
                selectedKey = Keys.None;
            }

            keyListCombobox.DataSource = Enum.GetValues<Keys>();
            enableRemappingCheckbox.Checked = Settings.Default.UseOmenAlternateKey;
            execProgramCheckbox.Checked = Settings.Default.UseOmenKeyExecute;
            selectedKey = Settings.Default.AlternateKey;
            fileExecPath.Text = Settings.Default.ExecutePath;
            fileExecArguments.Text = Settings.Default.ExecuteArguments;
            UpdateUI();
        }

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            isListening = !isListening;
            if (isListening)
            {
                IdentifyButton.Text = "Listening...";
            }
            else
            {
                IdentifyButton.Text = "Identify";
            }
        }

        private readonly Color activeColor = Color.FromArgb(153, 153, 153);
        private readonly Color inactiveColor = Color.FromArgb(64, 64, 64);
        private readonly Color activeTextColor = Color.FromArgb(31, 31, 31);
        private readonly Color inactiveTextColor = Color.FromArgb(230, 230, 230);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isListening)
            {
                Keys noModifiersKey = ((Keys)((int)keyData & ~-65536));

                if (noModifiersKey == Keys.ShiftKey || noModifiersKey == Keys.ControlKey || noModifiersKey == Keys.Menu)
                {
                    return true;
                }
                selectedKey = keyData;

                Invoke(UpdateUI);

                // Reset listening state
                IdentifyButton_Click(new object(), EventArgs.Empty);
                enableRemappingCheckbox.Checked = true;

                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Settings.Default.AlternateKey = selectedKey;
            Settings.Default.Save();
            Close();
        }

        private void enableRemappingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableRemappingCheckbox.Checked)
                execProgramCheckbox.Checked = false;
            Settings.Default.UseOmenAlternateKey = enableRemappingCheckbox.Checked;
            Settings.Default.Save();
        }

        private void keyListCombobox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedKey = (Keys)keyListCombobox.SelectedItem;
            if (Created)
                Invoke(UpdateUI);
        }

        private void UpdateUI()
        {
            Keys noModifiersKey = ((Keys)((int)selectedKey & ~-65536));

            // Dont trigger event
            keyListCombobox.SelectedIndexChanged -= keyListCombobox_SelectedIndexChanged;
            keyListCombobox.SelectedItem = noModifiersKey;
            keyListCombobox.SelectedIndexChanged += keyListCombobox_SelectedIndexChanged;

            CtrlButton.BackColor = selectedKey.HasFlag(Keys.Control) ? activeColor : inactiveColor;
            AltBtn.BackColor = selectedKey.HasFlag(Keys.Alt) ? activeColor : inactiveColor;
            ShiftBtn.BackColor = selectedKey.HasFlag(Keys.Shift) ? activeColor : inactiveColor;
            CtrlButton.ForeColor = selectedKey.HasFlag(Keys.Control) ? activeTextColor : inactiveTextColor;
            AltBtn.ForeColor = selectedKey.HasFlag(Keys.Alt) ? activeTextColor : inactiveTextColor;
            ShiftBtn.ForeColor = selectedKey.HasFlag(Keys.Shift) ? activeTextColor : inactiveTextColor;
        }

        private void CtrlButton_Click(object sender, EventArgs e)
        {
            if (selectedKey.HasFlag(Keys.Control))
                selectedKey &= ~Keys.Control;
            else
                selectedKey |= Keys.Control;
            UpdateUI();
        }

        private void AltBtn_Click(object sender, EventArgs e)
        {
            if (selectedKey.HasFlag(Keys.Alt))
                selectedKey &= ~Keys.Alt;
            else
                selectedKey |= Keys.Alt;
            UpdateUI();
        }

        private void ShiftBtn_Click(object sender, EventArgs e)
        {
            if (selectedKey.HasFlag(Keys.Shift))
                selectedKey &= ~Keys.Shift;
            else
                selectedKey |= Keys.Shift;
            UpdateUI();
        }

        private void execProgramCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (execProgramCheckbox.Checked)
                enableRemappingCheckbox.Checked = false;
            Settings.Default.UseOmenKeyExecute = execProgramCheckbox.Checked;
            Settings.Default.Save();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            selectProgramDialog.ShowDialog();
        }

        private void selectProgramDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fileExecPath.Text = selectProgramDialog.FileName;
        }

        private void fileExecPath_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ExecutePath = fileExecPath.Text;
            Settings.Default.Save();
        }

        private void testBtn_Click(object sender, EventArgs e)
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

        private void fileExecArguments_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ExecuteArguments = fileExecArguments.Text;
            Settings.Default.Save();
        }
    }
}
