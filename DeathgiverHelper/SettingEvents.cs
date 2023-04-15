using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathgiverHelper
{
    partial class Setting
    {
        private void button2_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                panel1.BackColor = selectedColor;

                currentSettings.color = selectedColor;

                updateUI();
            }
        }

        private void widthR_Click(object sender, EventArgs e)
        {
            textBoxWidth.Text = "" + (Convert.ToInt32(textBoxWidth.Text) + 1);
        }

        private void heightR_Click(object sender, EventArgs e)
        {
            textBoxHeight.Text = "" + (Convert.ToInt32(textBoxHeight.Text) + 1);
        }

        private void Xright_Click(object sender, EventArgs e)
        {
            textBoxX.Text = "" + (Convert.ToInt32(textBoxX.Text) + 1);
        }

        private void Yright_Click(object sender, EventArgs e)
        {
            textBoxY.Text = "" + (Convert.ToInt32(textBoxY.Text) + 1);
        }

        private void XLeft_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxX.Text) - 1 > 0)
                textBoxX.Text = "" + (Convert.ToInt32(textBoxX.Text) - 1);
        }

        private void YLeft_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxY.Text) - 1 > 0)
                textBoxY.Text = "" + (Convert.ToInt32(textBoxY.Text) - 1);
        }

        private void WidthLeft_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxWidth.Text) - 1 > 0)
                textBoxWidth.Text = "" + (Convert.ToInt32(textBoxWidth.Text) - 1);
        }

        private void LeftHeight_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxHeight.Text) - 1 > 0)
                textBoxHeight.Text = "" + (Convert.ToInt32(textBoxHeight.Text) - 1);
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.Show();
        }
    }
}
