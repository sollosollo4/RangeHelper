using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathgiverHelper
{
    public partial class spellIco : Form
    {
        int width;
        int height;
        int x;
        int y;
        int brushsize = 4;
        Color color;

        public spellIco(Settings settings)
        {
            this.width = settings.width;
            this.height = settings.height;
            this.x = settings.x;
            this.y = settings.y;
            this.brushsize = settings.brushsize;
            this.color = settings.color;

            InitializeComponent();

            this.TransparencyKey = SystemColors.Control;

            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            this.Size = resolution;

            TopMost = true;
        }

        private void spellIco_Paint(object sender, PaintEventArgs e)
        {
            Point topLeft = new Point()
            {
                X = (ClientRectangle.Width - width) / 2 - x,
                Y = (ClientRectangle.Height - height) / 2 + y
            };

            Pen pen = new Pen(color, brushsize);
            Graphics g = panel1.CreateGraphics();
            g.DrawEllipse(pen, topLeft.X, topLeft.Y, width, height);
        }
    }
}