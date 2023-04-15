namespace DeathgiverHelper
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.е = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBrushSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectSettings = new System.Windows.Forms.ComboBox();
            this.AddNewSettings = new System.Windows.Forms.Button();
            this.DeleteSettings = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.widthR = new System.Windows.Forms.Button();
            this.heightR = new System.Windows.Forms.Button();
            this.Xright = new System.Windows.Forms.Button();
            this.Yright = new System.Windows.Forms.Button();
            this.WidthLeft = new System.Windows.Forms.Button();
            this.LeftHeight = new System.Windows.Forms.Button();
            this.XLeft = new System.Windows.Forms.Button();
            this.YLeft = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bugHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(4, 5);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 30);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "On/Off";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxWidth.Location = new System.Drawing.Point(23, 212);
            this.textBoxWidth.MaxLength = 4;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(82, 34);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "1190";
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxHeight.Location = new System.Drawing.Point(23, 278);
            this.textBoxHeight.MaxLength = 4;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(82, 34);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.Text = "980";
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            this.toolTip1.SetToolTip(this.label2, "width of your ellipse");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height";
            this.toolTip1.SetToolTip(this.label3, "height of your ellipse");
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxX.Location = new System.Drawing.Point(120, 212);
            this.textBoxX.MaxLength = 4;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(82, 34);
            this.textBoxX.TabIndex = 2;
            this.textBoxX.Text = "10";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxY.Location = new System.Drawing.Point(120, 278);
            this.textBoxY.MaxLength = 4;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(82, 34);
            this.textBoxY.TabIndex = 2;
            this.textBoxY.Text = "62";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // е
            // 
            this.е.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.е.AutoSize = true;
            this.е.Location = new System.Drawing.Point(115, 183);
            this.е.Name = "е";
            this.е.Size = new System.Drawing.Size(26, 26);
            this.е.TabIndex = 3;
            this.е.Text = "X";
            this.toolTip1.SetToolTip(this.е, "offset from center for ellipses");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            this.toolTip1.SetToolTip(this.label5, "offset from center for ellipses");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-1, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "by AnimeDevka (c) Turn Off | N0 FEAR #1 / neverant my papi, yappi is my momy | ap" +
    "p-v2\r\n";
            // 
            // textBoxBrushSize
            // 
            this.textBoxBrushSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBrushSize.Location = new System.Drawing.Point(112, 119);
            this.textBoxBrushSize.MaxLength = 4;
            this.textBoxBrushSize.Name = "textBoxBrushSize";
            this.textBoxBrushSize.Size = new System.Drawing.Size(37, 34);
            this.textBoxBrushSize.TabIndex = 2;
            this.textBoxBrushSize.Text = "4";
            this.textBoxBrushSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "BrushSize";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(2, 79);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 34);
            this.textBoxName.TabIndex = 8;
            // 
            // comboBoxSelectSettings
            // 
            this.comboBoxSelectSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSelectSettings.FormattingEnabled = true;
            this.comboBoxSelectSettings.Location = new System.Drawing.Point(2, 35);
            this.comboBoxSelectSettings.Name = "comboBoxSelectSettings";
            this.comboBoxSelectSettings.Size = new System.Drawing.Size(499, 34);
            this.comboBoxSelectSettings.TabIndex = 9;
            this.comboBoxSelectSettings.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSettings_SelectedIndexChanged);
            // 
            // AddNewSettings
            // 
            this.AddNewSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewSettings.Location = new System.Drawing.Point(8, 318);
            this.AddNewSettings.Name = "AddNewSettings";
            this.AddNewSettings.Size = new System.Drawing.Size(194, 34);
            this.AddNewSettings.TabIndex = 7;
            this.AddNewSettings.Text = "Add new/Save";
            this.AddNewSettings.UseVisualStyleBackColor = true;
            this.AddNewSettings.Click += new System.EventHandler(this.AddNewSettingsClick);
            // 
            // DeleteSettings
            // 
            this.DeleteSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSettings.Location = new System.Drawing.Point(208, 318);
            this.DeleteSettings.Name = "DeleteSettings";
            this.DeleteSettings.Size = new System.Drawing.Size(87, 34);
            this.DeleteSettings.TabIndex = 7;
            this.DeleteSettings.Text = "Delete";
            this.DeleteSettings.UseVisualStyleBackColor = true;
            this.DeleteSettings.Click += new System.EventHandler(this.DeleteSettingsClick);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // widthR
            // 
            this.widthR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthR.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthR.Location = new System.Drawing.Point(89, 212);
            this.widthR.Name = "widthR";
            this.widthR.Size = new System.Drawing.Size(16, 34);
            this.widthR.TabIndex = 12;
            this.widthR.Text = ">";
            this.widthR.UseVisualStyleBackColor = true;
            this.widthR.Click += new System.EventHandler(this.widthR_Click);
            // 
            // heightR
            // 
            this.heightR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightR.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightR.Location = new System.Drawing.Point(89, 278);
            this.heightR.Name = "heightR";
            this.heightR.Size = new System.Drawing.Size(16, 34);
            this.heightR.TabIndex = 12;
            this.heightR.Text = ">";
            this.heightR.UseVisualStyleBackColor = true;
            this.heightR.Click += new System.EventHandler(this.heightR_Click);
            // 
            // Xright
            // 
            this.Xright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xright.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xright.Location = new System.Drawing.Point(186, 212);
            this.Xright.Name = "Xright";
            this.Xright.Size = new System.Drawing.Size(16, 34);
            this.Xright.TabIndex = 12;
            this.Xright.Text = ">";
            this.Xright.UseVisualStyleBackColor = true;
            this.Xright.Click += new System.EventHandler(this.Xright_Click);
            // 
            // Yright
            // 
            this.Yright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Yright.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yright.Location = new System.Drawing.Point(186, 278);
            this.Yright.Name = "Yright";
            this.Yright.Size = new System.Drawing.Size(16, 34);
            this.Yright.TabIndex = 12;
            this.Yright.Text = ">";
            this.Yright.UseVisualStyleBackColor = true;
            this.Yright.Click += new System.EventHandler(this.Yright_Click);
            // 
            // WidthLeft
            // 
            this.WidthLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLeft.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLeft.Location = new System.Drawing.Point(23, 212);
            this.WidthLeft.Name = "WidthLeft";
            this.WidthLeft.Size = new System.Drawing.Size(16, 34);
            this.WidthLeft.TabIndex = 12;
            this.WidthLeft.Text = "<";
            this.WidthLeft.UseVisualStyleBackColor = true;
            this.WidthLeft.Click += new System.EventHandler(this.WidthLeft_Click);
            // 
            // LeftHeight
            // 
            this.LeftHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftHeight.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftHeight.Location = new System.Drawing.Point(23, 278);
            this.LeftHeight.Name = "LeftHeight";
            this.LeftHeight.Size = new System.Drawing.Size(16, 34);
            this.LeftHeight.TabIndex = 12;
            this.LeftHeight.Text = "<";
            this.LeftHeight.UseVisualStyleBackColor = true;
            this.LeftHeight.Click += new System.EventHandler(this.LeftHeight_Click);
            // 
            // XLeft
            // 
            this.XLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XLeft.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XLeft.Location = new System.Drawing.Point(120, 212);
            this.XLeft.Name = "XLeft";
            this.XLeft.Size = new System.Drawing.Size(16, 34);
            this.XLeft.TabIndex = 12;
            this.XLeft.Text = "<";
            this.XLeft.UseVisualStyleBackColor = true;
            this.XLeft.Click += new System.EventHandler(this.XLeft_Click);
            // 
            // YLeft
            // 
            this.YLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YLeft.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YLeft.Location = new System.Drawing.Point(120, 278);
            this.YLeft.Name = "YLeft";
            this.YLeft.Size = new System.Drawing.Size(16, 34);
            this.YLeft.TabIndex = 12;
            this.YLeft.Text = "<";
            this.YLeft.UseVisualStyleBackColor = true;
            this.YLeft.Click += new System.EventHandler(this.YLeft_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AO| Range Helper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Location = new System.Drawing.Point(186, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 34);
            this.panel1.TabIndex = 13;
            // 
            // bugHelp
            // 
            this.bugHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bugHelp.AutoSize = true;
            this.bugHelp.Location = new System.Drawing.Point(480, 5);
            this.bugHelp.Name = "bugHelp";
            this.bugHelp.Size = new System.Drawing.Size(21, 26);
            this.bugHelp.TabIndex = 14;
            this.bugHelp.Text = "?";
            this.bugHelp.Click += new System.EventHandler(this.bugHelp_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 371);
            this.Controls.Add(this.bugHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Yright);
            this.Controls.Add(this.Xright);
            this.Controls.Add(this.heightR);
            this.Controls.Add(this.YLeft);
            this.Controls.Add(this.XLeft);
            this.Controls.Add(this.LeftHeight);
            this.Controls.Add(this.WidthLeft);
            this.Controls.Add(this.widthR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSelectSettings);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.DeleteSettings);
            this.Controls.Add(this.AddNewSettings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.е);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrushSize);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.checkBox2);
            this.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(520, 410);
            this.Name = "Setting";
            this.Text = "AO| Range Helper v2";
            this.Resize += new System.EventHandler(this.Setting_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label е;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBrushSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxSelectSettings;
        private System.Windows.Forms.Button AddNewSettings;
        private System.Windows.Forms.Button DeleteSettings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button widthR;
        private System.Windows.Forms.Button heightR;
        private System.Windows.Forms.Button Xright;
        private System.Windows.Forms.Button Yright;
        private System.Windows.Forms.Button WidthLeft;
        private System.Windows.Forms.Button LeftHeight;
        private System.Windows.Forms.Button XLeft;
        private System.Windows.Forms.Button YLeft;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bugHelp;
    }
}