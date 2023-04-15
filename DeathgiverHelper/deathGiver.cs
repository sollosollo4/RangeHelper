using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathgiverHelper
{
    public partial class deathGiver : Form
    {
        private GlobalKeyboardHook _globalKeyboardHook;

        int qCount = 0;
        int maxStack = 0;

        public deathGiver()
        {
            InitializeComponent();
            this.TransparencyKey = SystemColors.Control;

            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            this.Size = resolution;

            deathGiverBuff.BackColor = Color.FromArgb(25);
            TopMost = true;

            //_globalKeyboardHook = new GlobalKeyboardHook();
           // _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            //if (e.KeyboardData.VirtualCode != GlobalKeyboardHook.VkSnapshot)
                //return;

           //var outKey = e.KeyboardData.Flags;

            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown && e.KeyboardData.VirtualCode == GlobalKeyboardHook.deathGiverdown)
            {
                if (timerQ.Enabled)
                {
                    timerQ.Stop();

                    qCount = 0;
                    maxStack = 0;
                    qLabel.Text = "-" + qCount;
                    qLabel.ForeColor = Color.Yellow;

                    timerQ.Interval = 10;
                }
                else
                    timerQ.Start();
                e.Handled = true;
            }

            if(e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown && e.KeyboardData.VirtualCode == GlobalKeyboardHook.deathGiverEdown)
            {
                qCount = 0;
                qLabel.ForeColor = Color.Blue;
                qLabel.Text = "" + qCount;
            }
        }

        private void timerQ_Tick(object sender, EventArgs e)
        {
            qLabel.ForeColor = Color.Blue;
            timerQ.Interval = 3000;

            qCount++;
            if(qCount >= 3)
            {
                qCount = 3;
                maxStack++;
                qLabel.ForeColor = Color.Red;
            }

            qLabel.Text = "" + qCount;

            if (maxStack == 4)
            {
                qCount = 0;
                maxStack = 0;
                qLabel.Text = "" + qCount;
                qLabel.ForeColor = Color.Blue;

                timerQ.Interval = 10;
                timerQ.Stop();
                SendKeys.Send("q");
                timerQ.Start();
            }
        }

        private void deathGiver_Paint(object sender, PaintEventArgs e)
        {
            Point topLeft = new Point()
            {
                X = (this.ClientRectangle.Width - 580) / 2,
                Y = (this.ClientRectangle.Height - 460) / 2 - 40
            };

            Pen pen = new Pen(Color.Yellow, 3);
            e.Graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, 580, 460);
        }
    }
}
