namespace DeathgiverHelper
{
    partial class deathGiver
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deathGiver));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deathGiverBuff = new System.Windows.Forms.Panel();
            this.qLabel = new System.Windows.Forms.Label();
            this.timerQ = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.deathGiverBuff, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.qLabel, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.84099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.057267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.875488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.46414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.deathGiver_Paint);
            // 
            // deathGiverBuff
            // 
            this.deathGiverBuff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deathGiverBuff.BackgroundImage")));
            this.deathGiverBuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deathGiverBuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deathGiverBuff.Location = new System.Drawing.Point(852, 225);
            this.deathGiverBuff.Margin = new System.Windows.Forms.Padding(0);
            this.deathGiverBuff.Name = "deathGiverBuff";
            this.deathGiverBuff.Size = new System.Drawing.Size(213, 76);
            this.deathGiverBuff.TabIndex = 2;
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLabel.Location = new System.Drawing.Point(852, 301);
            this.qLabel.Margin = new System.Windows.Forms.Padding(0);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(213, 74);
            this.qLabel.TabIndex = 3;
            this.qLabel.Text = "CNT";
            this.qLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerQ
            // 
            this.timerQ.Interval = 10;
            // 
            // deathGiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deathGiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.deathGiver_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timerQ;
        private System.Windows.Forms.Panel deathGiverBuff;
        private System.Windows.Forms.Label qLabel;
    }
}

