namespace OmenHubLighter.Forms
{
    partial class BackgroundForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            this.TaskbarNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskbarChangeOmenKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TaskbarRunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskbarQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskbarNotifyIcon
            // 
            this.TaskbarNotifyIcon.BalloonTipTitle = "OmenHubLighter";
            this.TaskbarNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.TaskbarNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarNotifyIcon.Icon")));
            this.TaskbarNotifyIcon.Text = "OmenHubLighter";
            this.TaskbarNotifyIcon.Visible = true;
            this.TaskbarNotifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskbarNotifyIcon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskbarChangeOmenKey,
            this.toolStripSeparator1,
            this.TaskbarRunOnStartup,
            this.TaskbarQuit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 76);
            // 
            // TaskbarChangeOmenKey
            // 
            this.TaskbarChangeOmenKey.Name = "TaskbarChangeOmenKey";
            this.TaskbarChangeOmenKey.Size = new System.Drawing.Size(191, 22);
            this.TaskbarChangeOmenKey.Text = "Remap Omen key to...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // TaskbarRunOnStartup
            // 
            this.TaskbarRunOnStartup.CheckOnClick = true;
            this.TaskbarRunOnStartup.Name = "TaskbarRunOnStartup";
            this.TaskbarRunOnStartup.Size = new System.Drawing.Size(191, 22);
            this.TaskbarRunOnStartup.Text = "Run on startup";
            // 
            // TaskbarQuit
            // 
            this.TaskbarQuit.Name = "TaskbarQuit";
            this.TaskbarQuit.Size = new System.Drawing.Size(191, 22);
            this.TaskbarQuit.Text = "Quit";
            this.TaskbarQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackgroundForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon TaskbarNotifyIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem TaskbarQuit;
        private ToolStripMenuItem TaskbarChangeOmenKey;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem TaskbarRunOnStartup;
    }
}