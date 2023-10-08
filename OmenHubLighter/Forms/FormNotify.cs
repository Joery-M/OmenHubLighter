using Hp.Omen.OmenCommonLib.PowerControl.Enum;
using OmenHubLighter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace OmenHubLighter.Forms
{
    public partial class FormNotify : Form
    {
        private Timer hideTimer = new();
        private Timer fadeOutTimer = new();
        public FormNotify()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            var screenBounds = Screen.PrimaryScreen.Bounds;
            Location = new Point((screenBounds.Width / 2) - (Width / 2), screenBounds.Height - (this.Height + 50));
            base.OnShown(e);
            fadeOutTimer.Interval = 7;
            hideTimer.Interval = 1000;
            hideTimer.Tick += (sender, e) =>
            {
                fadeOutTimer.Start();
            };

            fadeOutTimer.Tick += (sender, e) =>
            {
                Opacity -= 0.025;
                if (Opacity <= 0)
                {
                    Hide();
                    fadeOutTimer.Stop();
                }
            };
        }

        public delegate void NotifyDelegate(ButtonType button, bool isEnabled);
        public void Notify(ButtonType button, bool isEnabled)
        {
            if (button == ButtonType.Winkey)
            {
                if (isEnabled)
                    statusImage.Image = Resources.winkeyUnlocked;
                else
                    statusImage.Image = Resources.winkeyLocked;
            }
            if (button == ButtonType.Trackpad)
            {
                if (isEnabled)
                    statusImage.Image = Resources.trackpadUnlocked;
                else
                    statusImage.Image = Resources.trackpadLocked;
            }
            Show();
            fadeOutTimer.Stop();
            Opacity = 1;
            hideTimer.Stop();
            hideTimer.Start();
        }
    }

    public enum ButtonType
    {
        Winkey,
        Trackpad
    }
}
