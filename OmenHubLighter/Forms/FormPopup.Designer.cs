namespace OmenHubLighter.Forms
{
    partial class FormPopup
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
            this.OffButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.fanList = new System.Windows.Forms.Label();
            this.gpuTempLabel = new System.Windows.Forms.Label();
            this.cpuTempLabel = new System.Windows.Forms.Label();
            this.PerformanceButton = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.QuietButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OffButton
            // 
            this.OffButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OffButton.FlatAppearance.BorderSize = 0;
            this.OffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OffButton.Location = new System.Drawing.Point(55, 148);
            this.OffButton.Margin = new System.Windows.Forms.Padding(0);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(84, 84);
            this.OffButton.TabIndex = 3;
            this.OffButton.Text = "Off";
            this.OffButton.UseVisualStyleBackColor = false;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxButton.FlatAppearance.BorderSize = 0;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MaxButton.Location = new System.Drawing.Point(143, 148);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(84, 84);
            this.MaxButton.TabIndex = 4;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = false;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // fanList
            // 
            this.fanList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fanList.AutoSize = true;
            this.fanList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fanList.Location = new System.Drawing.Point(209, 9);
            this.fanList.Name = "fanList";
            this.fanList.Size = new System.Drawing.Size(63, 30);
            this.fanList.TabIndex = 2;
            this.fanList.Text = "Fan 1: 30%\r\nFan 2: 40%";
            this.fanList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpuTempLabel
            // 
            this.gpuTempLabel.AutoSize = true;
            this.gpuTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gpuTempLabel.Location = new System.Drawing.Point(12, 24);
            this.gpuTempLabel.Name = "gpuTempLabel";
            this.gpuTempLabel.Size = new System.Drawing.Size(61, 15);
            this.gpuTempLabel.TabIndex = 1;
            this.gpuTempLabel.Text = "GPU: 00°C";
            // 
            // cpuTempLabel
            // 
            this.cpuTempLabel.AutoSize = true;
            this.cpuTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cpuTempLabel.Location = new System.Drawing.Point(12, 9);
            this.cpuTempLabel.Name = "cpuTempLabel";
            this.cpuTempLabel.Size = new System.Drawing.Size(61, 15);
            this.cpuTempLabel.TabIndex = 0;
            this.cpuTempLabel.Text = "CPU: 00°C";
            // 
            // PerformanceButton
            // 
            this.PerformanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerformanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PerformanceButton.FlatAppearance.BorderSize = 0;
            this.PerformanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PerformanceButton.Location = new System.Drawing.Point(188, 60);
            this.PerformanceButton.Margin = new System.Windows.Forms.Padding(0);
            this.PerformanceButton.Name = "PerformanceButton";
            this.PerformanceButton.Size = new System.Drawing.Size(84, 84);
            this.PerformanceButton.TabIndex = 10;
            this.PerformanceButton.Text = "Performance";
            this.PerformanceButton.UseVisualStyleBackColor = false;
            this.PerformanceButton.Click += new System.EventHandler(this.PerformanceButton_Click);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DefaultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DefaultButton.FlatAppearance.BorderSize = 0;
            this.DefaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DefaultButton.Location = new System.Drawing.Point(100, 60);
            this.DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(84, 84);
            this.DefaultButton.TabIndex = 9;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = false;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // QuietButton
            // 
            this.QuietButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuietButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuietButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuietButton.FlatAppearance.BorderSize = 0;
            this.QuietButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuietButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.QuietButton.Location = new System.Drawing.Point(12, 60);
            this.QuietButton.Margin = new System.Windows.Forms.Padding(0);
            this.QuietButton.Name = "QuietButton";
            this.QuietButton.Size = new System.Drawing.Size(84, 84);
            this.QuietButton.TabIndex = 8;
            this.QuietButton.Text = "Quiet";
            this.QuietButton.UseVisualStyleBackColor = false;
            this.QuietButton.Click += new System.EventHandler(this.QuietButton_Click);
            // 
            // FormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.ControlBox = false;
            this.Controls.Add(this.PerformanceButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.QuietButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.fanList);
            this.Controls.Add(this.gpuTempLabel);
            this.Controls.Add(this.cpuTempLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPopup";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FormPopup_Leave);
            this.Leave += new System.EventHandler(this.FormPopup_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuietButton;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Label fanList;
        private System.Windows.Forms.Label gpuTempLabel;
        private System.Windows.Forms.Label cpuTempLabel;
        private CheckBox fanMaxButton;
        private Label label1;
        private Button PerformanceButton;
        private Button OffButton;
        private Button MaxButton;
        private ComboBox fanmodeManual;
    }
}