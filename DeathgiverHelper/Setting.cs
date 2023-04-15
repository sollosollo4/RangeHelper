using RangeHelper.Properties;
using System;
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
    public partial class Setting : Form
    {
        private readonly string applicationLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/settings.xml";
        public DictionaryEx<string, Settings> allSettings = new DictionaryEx<string, Settings>();
        spellIco spellIco;
        Color selectedColor = Color.Black;
        Settings currentSettings;
        List<Control> changable;
        public Setting()
        {
            InitializeComponent();

            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("On/Off", checkBox2_CheckedChanged),
                new MenuItem("Exit", Exit)
            });
            notifyIcon1.ContextMenu = ContextMenu;

            changable = new List<Control>()
            {
                textBoxWidth, textBoxHeight,
                textBoxX, textBoxY,
                textBoxBrushSize
            };
            changebleSubscribe();

            allSettings.Add("timestop", new Settings()
            {
                width = 1190,
                height = 980,
                x = 10,
                y = 62,
                brushsize = 2,
                color = Color.Yellow
            });
            comboBoxSelectSettings.Items.Add("timestop");

            allSettings.Add("locus", new Settings()
            {
                width = 1280,
                height = 1060,
                x = 10,
                y = 82,
                brushsize = 2,
                color = Color.Yellow
            });
            comboBoxSelectSettings.Items.Add("locus");

            readXmlFile();

            Settings first = allSettings.First().Value;
            currentSettings = new Settings()
            {
                width = first.width,
                height = first.height,
                x = first.x,
                y = first.y,
                brushsize = first.brushsize,
                color = first.color
            };
            spellIco = new spellIco(currentSettings);
            comboBoxSelectSettings.SelectedIndex = 0;
        }

        private void changebleSubscribe()
        {
            changable.ForEach(e => e.TextChanged += new EventHandler(valueChanged));
        }

        private void changebleUnSubscribe()
        {
            changable.ForEach(e => e.TextChanged -= new EventHandler(valueChanged));
        }

        void Exit(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;

            Application.Exit();
        }

        private void readXmlFile()
        {
            try
            {
                DictionaryEx<string, Settings> readSettings =
                    XmlFilefunctions.ReadFromXmlFile<DictionaryEx<string, Settings>>(applicationLocation);

                readSettings.ToList().ForEach(x => {
                    if (allSettings.ContainsKey(x.Key))
                    {
                        allSettings.Remove(x.Key);
                        comboBoxSelectSettings.Items.Remove(x.Key);
                    }
                    allSettings.Add(x.Key, x.Value);
                    comboBoxSelectSettings.Items.Add(x.Key);
                });
            }
            catch(Exception e)
            {
                MessageBox.Show("Welcome to Albion Online | Range-Helper.");
            }
        }

        private void updatePanelInfo()
        {
            if(allSettings.TryGetValue(comboBoxSelectSettings.Text, out Settings getSettings))
            {
                currentSettings = new Settings()
                {
                    width = getSettings.width,
                    height = getSettings.height,
                    x = getSettings.x,
                    y = getSettings.y,
                    brushsize = getSettings.brushsize,
                    color = getSettings.color
                };
                panel1.BackColor = currentSettings.color;
                textBoxName.Text = comboBoxSelectSettings.Text;

                changebleUnSubscribe();
                textBoxWidth.Text = currentSettings.width.ToString();
                textBoxHeight.Text = currentSettings.height.ToString();
                textBoxX.Text = currentSettings.x.ToString();
                textBoxY.Text = currentSettings.y.ToString();
                textBoxBrushSize.Text = currentSettings.brushsize.ToString();
                changebleSubscribe();
            }
        }

        private void comboBoxSelectSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePanelInfo();
            updateUI();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is MenuItem)
                checkBox2.Checked = !checkBox2.Checked;

            if (!spellIco.IsDisposed)
            {
                OnOff();
            }
            else
            {
                updateUI();
            }
        }

        public void OnOff()
        {
            if (checkBox2.Checked)
            {
                spellIco.Show();
            }
            else
            {
                spellIco.Close();
            }
        }

        private void DeleteSettingsClick(object sender, EventArgs e)
        {
            int lastIndex = comboBoxSelectSettings.SelectedIndex;
            if (lastIndex > 0 && MessageBox.Show("Are you sure?", $"Deleting settings \"{comboBoxSelectSettings.Text}\"", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                allSettings.Remove(comboBoxSelectSettings.Text);
                comboBoxSelectSettings.Items.Remove(comboBoxSelectSettings.Text);
                comboBoxSelectSettings.SelectedIndex = lastIndex-1;
                updatePanelInfo();

                XmlFilefunctions.WriteToXmlFile(applicationLocation, allSettings, false);
            }
        }

        private void valueChanged(object sender, EventArgs e)
        {
            currentSettings.width = Convert.ToInt32(textBoxWidth.Text);
            currentSettings.height = Convert.ToInt32(textBoxHeight.Text);

            currentSettings.x = Convert.ToInt32(textBoxX.Text);
            currentSettings.y = Convert.ToInt32(textBoxY.Text);

            currentSettings.brushsize = Convert.ToInt32(textBoxBrushSize.Text);

            updateUI();
        }
                
        private void updateUI()
        {
            if (spellIco != null)
                spellIco.Close();

            spellIco = new spellIco(currentSettings);

            OnOff();
        }

        private void AddNewSettingsClick(object sender, EventArgs e)
        {
            if (!allSettings.ContainsKey(textBoxName.Text))
            {
                allSettings.Add(textBoxName.Text, currentSettings);
                comboBoxSelectSettings.Items.Add(textBoxName.Text);
                comboBoxSelectSettings.SelectedIndex = comboBoxSelectSettings.Items.Count-1;

                saveFile();
            }
            else
            {
                if(MessageBox.Show("You can't add new settings with the same names. But you can save. Do you want save this settings?", 
                    "Error with add :"+ textBoxName.Text,
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(allSettings.ContainsKey(textBoxName.Text))
                    {
                        allSettings[textBoxName.Text] = currentSettings;

                        saveFile();
                    }
                }
                else
                {
                    textBoxName.Focus();
                }
            }
        }

        public void saveFile()
        {
            XmlFilefunctions.WriteToXmlFile(applicationLocation, allSettings, false);
        }

        private void Setting_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void bugHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Found a bug? Write to discord or email: Ekcnert#1493 / dambas.ss@mail.ru", "Found the bug?");
        }
    }
}
