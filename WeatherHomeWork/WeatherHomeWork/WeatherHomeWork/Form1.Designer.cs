namespace WeatherHomeWork
{
    partial class Form1
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
            this.lbCitys = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbTemperature = new System.Windows.Forms.GroupBox();
            this.lblTemperatureValueMax = new System.Windows.Forms.Label();
            this.lblTemperatureValueMin = new System.Windows.Forms.Label();
            this.lblTemperatureMax = new System.Windows.Forms.Label();
            this.lblTemperatureMin = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gbPressure = new System.Windows.Forms.GroupBox();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPressureValueMax = new System.Windows.Forms.Label();
            this.lblPressureValueMin = new System.Windows.Forms.Label();
            this.lblPressureMax = new System.Windows.Forms.Label();
            this.lblPressureMin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbClient.SuspendLayout();
            this.gbTemperature.SuspendLayout();
            this.gbPressure.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCitys
            // 
            this.lbCitys.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCitys.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCitys.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCitys.ItemHeight = 23;
            this.lbCitys.Location = new System.Drawing.Point(0, 24);
            this.lbCitys.Margin = new System.Windows.Forms.Padding(6);
            this.lbCitys.Name = "lbCitys";
            this.lbCitys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCitys.Size = new System.Drawing.Size(433, 580);
            this.lbCitys.TabIndex = 0;
            this.lbCitys.SelectedIndexChanged += new System.EventHandler(this.lbCitys_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(433, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(6);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 580);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.gbTemperature);
            this.gbClient.Controls.Add(this.splitter2);
            this.gbClient.Controls.Add(this.gbPressure);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(439, 24);
            this.gbClient.Margin = new System.Windows.Forms.Padding(6);
            this.gbClient.Name = "gbClient";
            this.gbClient.Padding = new System.Windows.Forms.Padding(6);
            this.gbClient.Size = new System.Drawing.Size(677, 580);
            this.gbClient.TabIndex = 2;
            this.gbClient.TabStop = false;
            // 
            // gbTemperature
            // 
            this.gbTemperature.Controls.Add(this.lblTemperatureValueMax);
            this.gbTemperature.Controls.Add(this.lblTemperatureValueMin);
            this.gbTemperature.Controls.Add(this.lblTemperatureMax);
            this.gbTemperature.Controls.Add(this.lblTemperatureMin);
            this.gbTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTemperature.Location = new System.Drawing.Point(6, 212);
            this.gbTemperature.Margin = new System.Windows.Forms.Padding(6);
            this.gbTemperature.Name = "gbTemperature";
            this.gbTemperature.Padding = new System.Windows.Forms.Padding(6);
            this.gbTemperature.Size = new System.Drawing.Size(665, 362);
            this.gbTemperature.TabIndex = 2;
            this.gbTemperature.TabStop = false;
            this.gbTemperature.Text = "Температура";
            // 
            // lblTemperatureValueMax
            // 
            this.lblTemperatureValueMax.AutoSize = true;
            this.lblTemperatureValueMax.Location = new System.Drawing.Point(92, 93);
            this.lblTemperatureValueMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureValueMax.Name = "lblTemperatureValueMax";
            this.lblTemperatureValueMax.Size = new System.Drawing.Size(0, 23);
            this.lblTemperatureValueMax.TabIndex = 3;
            // 
            // lblTemperatureValueMin
            // 
            this.lblTemperatureValueMin.AutoSize = true;
            this.lblTemperatureValueMin.Location = new System.Drawing.Point(92, 43);
            this.lblTemperatureValueMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureValueMin.Name = "lblTemperatureValueMin";
            this.lblTemperatureValueMin.Size = new System.Drawing.Size(0, 23);
            this.lblTemperatureValueMin.TabIndex = 2;
            // 
            // lblTemperatureMax
            // 
            this.lblTemperatureMax.AutoSize = true;
            this.lblTemperatureMax.Location = new System.Drawing.Point(16, 93);
            this.lblTemperatureMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureMax.Name = "lblTemperatureMax";
            this.lblTemperatureMax.Size = new System.Drawing.Size(46, 23);
            this.lblTemperatureMax.TabIndex = 1;
            this.lblTemperatureMax.Text = "max";
            // 
            // lblTemperatureMin
            // 
            this.lblTemperatureMin.AutoSize = true;
            this.lblTemperatureMin.Location = new System.Drawing.Point(18, 43);
            this.lblTemperatureMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureMin.Name = "lblTemperatureMin";
            this.lblTemperatureMin.Size = new System.Drawing.Size(42, 23);
            this.lblTemperatureMin.TabIndex = 0;
            this.lblTemperatureMin.Text = "min";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(6, 206);
            this.splitter2.Margin = new System.Windows.Forms.Padding(6);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(665, 6);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // gbPressure
            // 
            this.gbPressure.Controls.Add(this.lblTimeValue);
            this.gbPressure.Controls.Add(this.lblDateValue);
            this.gbPressure.Controls.Add(this.lblTime);
            this.gbPressure.Controls.Add(this.lblDate);
            this.gbPressure.Controls.Add(this.lblPressureValueMax);
            this.gbPressure.Controls.Add(this.lblPressureValueMin);
            this.gbPressure.Controls.Add(this.lblPressureMax);
            this.gbPressure.Controls.Add(this.lblPressureMin);
            this.gbPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPressure.Location = new System.Drawing.Point(6, 29);
            this.gbPressure.Margin = new System.Windows.Forms.Padding(6);
            this.gbPressure.Name = "gbPressure";
            this.gbPressure.Padding = new System.Windows.Forms.Padding(6);
            this.gbPressure.Size = new System.Drawing.Size(665, 177);
            this.gbPressure.TabIndex = 0;
            this.gbPressure.TabStop = false;
            this.gbPressure.Text = "Давление";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Location = new System.Drawing.Point(103, 60);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(0, 23);
            this.lblTimeValue.TabIndex = 7;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Location = new System.Drawing.Point(102, 27);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(0, 23);
            this.lblDateValue.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Время";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата";
            // 
            // lblPressureValueMax
            // 
            this.lblPressureValueMax.AutoSize = true;
            this.lblPressureValueMax.Location = new System.Drawing.Point(70, 136);
            this.lblPressureValueMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureValueMax.Name = "lblPressureValueMax";
            this.lblPressureValueMax.Size = new System.Drawing.Size(0, 23);
            this.lblPressureValueMax.TabIndex = 3;
            // 
            // lblPressureValueMin
            // 
            this.lblPressureValueMin.AutoSize = true;
            this.lblPressureValueMin.Location = new System.Drawing.Point(67, 94);
            this.lblPressureValueMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureValueMin.Name = "lblPressureValueMin";
            this.lblPressureValueMin.Size = new System.Drawing.Size(0, 23);
            this.lblPressureValueMin.TabIndex = 2;
            // 
            // lblPressureMax
            // 
            this.lblPressureMax.AutoSize = true;
            this.lblPressureMax.Location = new System.Drawing.Point(12, 136);
            this.lblPressureMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureMax.Name = "lblPressureMax";
            this.lblPressureMax.Size = new System.Drawing.Size(46, 23);
            this.lblPressureMax.TabIndex = 1;
            this.lblPressureMax.Text = "max";
            // 
            // lblPressureMin
            // 
            this.lblPressureMin.AutoSize = true;
            this.lblPressureMin.Location = new System.Drawing.Point(12, 94);
            this.lblPressureMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureMin.Name = "lblPressureMin";
            this.lblPressureMin.Size = new System.Drawing.Size(42, 23);
            this.lblPressureMin.TabIndex = 0;
            this.lblPressureMin.Text = "min";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1116, 604);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbCitys);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClient.ResumeLayout(false);
            this.gbTemperature.ResumeLayout(false);
            this.gbTemperature.PerformLayout();
            this.gbPressure.ResumeLayout(false);
            this.gbPressure.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCitys;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbTemperature;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox gbPressure;
        private System.Windows.Forms.Label lblTemperatureValueMax;
        private System.Windows.Forms.Label lblTemperatureValueMin;
        private System.Windows.Forms.Label lblTemperatureMax;
        private System.Windows.Forms.Label lblTemperatureMin;
        private System.Windows.Forms.Label lblPressureValueMax;
        private System.Windows.Forms.Label lblPressureValueMin;
        private System.Windows.Forms.Label lblPressureMax;
        private System.Windows.Forms.Label lblPressureMin;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

