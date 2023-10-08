namespace OmenHubLighter.Forms
{
    partial class FormNotify
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
            this.statusImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            this.SuspendLayout();
            // 
            // statusImage
            // 
            this.statusImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusImage.Image = global::OmenHubLighter.Resources.trackpadUnlocked;
            this.statusImage.Location = new System.Drawing.Point(25, 25);
            this.statusImage.Margin = new System.Windows.Forms.Padding(0);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(100, 100);
            this.statusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusImage.TabIndex = 0;
            this.statusImage.TabStop = false;
            // 
            // FormNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(151, 151);
            this.ControlBox = false;
            this.Controls.Add(this.statusImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotify";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox statusImage;
    }
}