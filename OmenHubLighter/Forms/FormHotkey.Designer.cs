namespace OmenHubLighter.Forms
{
    partial class FormHotkey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotkey));
            this.keyListCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentifyButton = new System.Windows.Forms.Button();
            this.CtrlButton = new System.Windows.Forms.Button();
            this.AltBtn = new System.Windows.Forms.Button();
            this.ShiftBtn = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.enableRemappingCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.execProgramCheckbox = new System.Windows.Forms.CheckBox();
            this.selectProgramDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileExecPath = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.fileExecArguments = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyListCombobox
            // 
            this.keyListCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyListCombobox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.keyListCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyListCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.keyListCombobox.FormattingEnabled = true;
            this.keyListCombobox.Location = new System.Drawing.Point(12, 72);
            this.keyListCombobox.Name = "keyListCombobox";
            this.keyListCombobox.Size = new System.Drawing.Size(191, 23);
            this.keyListCombobox.TabIndex = 0;
            this.keyListCombobox.SelectedIndexChanged += new System.EventHandler(this.keyListCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set key to be used as the Omen key:";
            // 
            // IdentifyButton
            // 
            this.IdentifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdentifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IdentifyButton.FlatAppearance.BorderSize = 0;
            this.IdentifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdentifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.IdentifyButton.Location = new System.Drawing.Point(206, 71);
            this.IdentifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.IdentifyButton.Name = "IdentifyButton";
            this.IdentifyButton.Size = new System.Drawing.Size(96, 24);
            this.IdentifyButton.TabIndex = 9;
            this.IdentifyButton.Text = "Identify";
            this.IdentifyButton.UseVisualStyleBackColor = false;
            this.IdentifyButton.Click += new System.EventHandler(this.IdentifyButton_Click);
            // 
            // CtrlButton
            // 
            this.CtrlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CtrlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlButton.FlatAppearance.BorderSize = 0;
            this.CtrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CtrlButton.Location = new System.Drawing.Point(0, 0);
            this.CtrlButton.Margin = new System.Windows.Forms.Padding(0);
            this.CtrlButton.Name = "CtrlButton";
            this.CtrlButton.Size = new System.Drawing.Size(63, 23);
            this.CtrlButton.TabIndex = 10;
            this.CtrlButton.Text = "CTRL";
            this.CtrlButton.UseVisualStyleBackColor = false;
            this.CtrlButton.Click += new System.EventHandler(this.CtrlButton_Click);
            // 
            // AltBtn
            // 
            this.AltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AltBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AltBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AltBtn.FlatAppearance.BorderSize = 0;
            this.AltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AltBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AltBtn.Location = new System.Drawing.Point(67, 0);
            this.AltBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AltBtn.Name = "AltBtn";
            this.AltBtn.Size = new System.Drawing.Size(55, 23);
            this.AltBtn.TabIndex = 11;
            this.AltBtn.Text = "ALT";
            this.AltBtn.UseVisualStyleBackColor = false;
            this.AltBtn.Click += new System.EventHandler(this.AltBtn_Click);
            // 
            // ShiftBtn
            // 
            this.ShiftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShiftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShiftBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftBtn.FlatAppearance.BorderSize = 0;
            this.ShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShiftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ShiftBtn.Location = new System.Drawing.Point(126, 0);
            this.ShiftBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ShiftBtn.Name = "ShiftBtn";
            this.ShiftBtn.Size = new System.Drawing.Size(65, 23);
            this.ShiftBtn.TabIndex = 12;
            this.ShiftBtn.Text = "Shift";
            this.ShiftBtn.UseVisualStyleBackColor = false;
            this.ShiftBtn.Click += new System.EventHandler(this.ShiftBtn_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OKButton.Location = new System.Drawing.Point(241, 233);
            this.OKButton.Margin = new System.Windows.Forms.Padding(0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(61, 23);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton.Location = new System.Drawing.Point(12, 233);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(61, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // enableRemappingCheckbox
            // 
            this.enableRemappingCheckbox.AutoSize = true;
            this.enableRemappingCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.enableRemappingCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.enableRemappingCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.enableRemappingCheckbox.Location = new System.Drawing.Point(12, 40);
            this.enableRemappingCheckbox.Name = "enableRemappingCheckbox";
            this.enableRemappingCheckbox.Size = new System.Drawing.Size(84, 19);
            this.enableRemappingCheckbox.TabIndex = 15;
            this.enableRemappingCheckbox.Text = "Remap key";
            this.enableRemappingCheckbox.UseVisualStyleBackColor = true;
            this.enableRemappingCheckbox.CheckedChanged += new System.EventHandler(this.enableRemappingCheckbox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ShiftBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AltBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CtrlButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 23);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // execProgramCheckbox
            // 
            this.execProgramCheckbox.AutoSize = true;
            this.execProgramCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.execProgramCheckbox.Location = new System.Drawing.Point(12, 140);
            this.execProgramCheckbox.Name = "execProgramCheckbox";
            this.execProgramCheckbox.Size = new System.Drawing.Size(116, 19);
            this.execProgramCheckbox.TabIndex = 18;
            this.execProgramCheckbox.Text = "Execute program";
            this.execProgramCheckbox.UseVisualStyleBackColor = true;
            this.execProgramCheckbox.CheckedChanged += new System.EventHandler(this.execProgramCheckbox_CheckedChanged);
            // 
            // selectProgramDialog
            // 
            this.selectProgramDialog.FileName = "openFileDialog1";
            this.selectProgramDialog.SupportMultiDottedExtensions = true;
            this.selectProgramDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.selectProgramDialog_FileOk);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectFileButton.FlatAppearance.BorderSize = 0;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.selectFileButton.Location = new System.Drawing.Point(206, 164);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(96, 24);
            this.selectFileButton.TabIndex = 19;
            this.selectFileButton.Text = "Browse";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileExecPath
            // 
            this.fileExecPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileExecPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileExecPath.Location = new System.Drawing.Point(12, 165);
            this.fileExecPath.Name = "fileExecPath";
            this.fileExecPath.PlaceholderText = "File to execute";
            this.fileExecPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.fileExecPath.Size = new System.Drawing.Size(191, 23);
            this.fileExecPath.TabIndex = 20;
            this.fileExecPath.TextChanged += new System.EventHandler(this.fileExecPath_TextChanged);
            // 
            // testBtn
            // 
            this.testBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.testBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testBtn.FlatAppearance.BorderSize = 0;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.testBtn.Location = new System.Drawing.Point(206, 191);
            this.testBtn.Margin = new System.Windows.Forms.Padding(0);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(96, 24);
            this.testBtn.TabIndex = 21;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // fileExecArguments
            // 
            this.fileExecArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileExecArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileExecArguments.Location = new System.Drawing.Point(12, 191);
            this.fileExecArguments.Name = "fileExecArguments";
            this.fileExecArguments.PlaceholderText = "Arguments";
            this.fileExecArguments.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.fileExecArguments.Size = new System.Drawing.Size(191, 23);
            this.fileExecArguments.TabIndex = 22;
            this.fileExecArguments.TextChanged += new System.EventHandler(this.fileExecArguments_TextChanged);
            // 
            // FormHotkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(311, 265);
            this.ControlBox = false;
            this.Controls.Add(this.fileExecArguments);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.fileExecPath);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.execProgramCheckbox);
            this.Controls.Add(this.enableRemappingCheckbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IdentifyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyListCombobox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHotkey";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OmenHubLighter - Key remap";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox fanMaxButton;
        private Label label1;
        private ComboBox fanmodeManual;
        private ComboBox keyListCombobox;
        private Button IdentifyButton;
        private Button CtrlButton;
        private Button AltBtn;
        private Button ShiftBtn;
        private Button OKButton;
        private Button CancelButton;
        private CheckBox enableRemappingCheckbox;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox execProgramCheckbox;
        private OpenFileDialog selectProgramDialog;
        private Button selectFileButton;
        private TextBox fileExecPath;
        private Button testBtn;
        private TextBox textBox1;
        private TextBox execArguments;
        private TextBox fileExecArguments;
    }
}