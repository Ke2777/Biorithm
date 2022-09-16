namespace биоритма
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_dan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_per2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_per1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_period = new System.Windows.Forms.RadioButton();
            this.radioButton_year = new System.Windows.Forms.RadioButton();
            this.radioButton_mounth = new System.Windows.Forms.RadioButton();
            this.radioButton_nedelya = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_datarog = new System.Windows.Forms.DateTimePicker();
            this.checkBox_fiz = new System.Windows.Forms.CheckBox();
            this.checkBox_emo = new System.Windows.Forms.CheckBox();
            this.checkBox_inte = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_datarog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dan)).BeginInit();
            this.groupBox_period.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_dan
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_dan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_dan.Legends.Add(legend1);
            this.chart_dan.Location = new System.Drawing.Point(-1, 6);
            this.chart_dan.Name = "chart_dan";
            this.chart_dan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Legend = "Legend1";
            series1.Name = "физическое";
            series1.YValuesPerPoint = 3;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.LabelBorderColor = System.Drawing.Color.Navy;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series2.MarkerBorderWidth = 5;
            series2.MarkerColor = System.Drawing.Color.Fuchsia;
            series2.MarkerImageTransparentColor = System.Drawing.Color.Olive;
            series2.MarkerSize = 10;
            series2.MarkerStep = 5;
            series2.Name = "Эмоциональное";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Legend = "Legend1";
            series3.Name = "Интеликтуальное ";
            this.chart_dan.Series.Add(series1);
            this.chart_dan.Series.Add(series2);
            this.chart_dan.Series.Add(series3);
            this.chart_dan.Size = new System.Drawing.Size(472, 346);
            this.chart_dan.TabIndex = 0;
            this.chart_dan.Text = "chart1";
            this.chart_dan.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(61, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_period
            // 
            this.groupBox_period.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_period.Controls.Add(this.dateTimePicker_per2);
            this.groupBox_period.Controls.Add(this.dateTimePicker_per1);
            this.groupBox_period.Controls.Add(this.radioButton_period);
            this.groupBox_period.Controls.Add(this.radioButton_year);
            this.groupBox_period.Controls.Add(this.radioButton_mounth);
            this.groupBox_period.Controls.Add(this.radioButton_nedelya);
            this.groupBox_period.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_period.Location = new System.Drawing.Point(477, 110);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(252, 206);
            this.groupBox_period.TabIndex = 2;
            this.groupBox_period.TabStop = false;
            this.groupBox_period.Text = "Период";
            // 
            // dateTimePicker_per2
            // 
            this.dateTimePicker_per2.Location = new System.Drawing.Point(10, 164);
            this.dateTimePicker_per2.Name = "dateTimePicker_per2";
            this.dateTimePicker_per2.Size = new System.Drawing.Size(190, 26);
            this.dateTimePicker_per2.TabIndex = 5;
            // 
            // dateTimePicker_per1
            // 
            this.dateTimePicker_per1.Location = new System.Drawing.Point(10, 129);
            this.dateTimePicker_per1.Name = "dateTimePicker_per1";
            this.dateTimePicker_per1.Size = new System.Drawing.Size(190, 26);
            this.dateTimePicker_per1.TabIndex = 4;
            // 
            // radioButton_period
            // 
            this.radioButton_period.AutoSize = true;
            this.radioButton_period.Location = new System.Drawing.Point(38, 101);
            this.radioButton_period.Name = "radioButton_period";
            this.radioButton_period.Size = new System.Drawing.Size(81, 22);
            this.radioButton_period.TabIndex = 3;
            this.radioButton_period.TabStop = true;
            this.radioButton_period.Text = "Период";
            this.radioButton_period.UseVisualStyleBackColor = true;
            this.radioButton_period.Click += new System.EventHandler(this.radioButton_period_Click_1);
            // 
            // radioButton_year
            // 
            this.radioButton_year.AutoSize = true;
            this.radioButton_year.Location = new System.Drawing.Point(38, 78);
            this.radioButton_year.Name = "radioButton_year";
            this.radioButton_year.Size = new System.Drawing.Size(52, 22);
            this.radioButton_year.TabIndex = 2;
            this.radioButton_year.TabStop = true;
            this.radioButton_year.Text = "Год";
            this.radioButton_year.UseVisualStyleBackColor = true;
            this.radioButton_year.Click += new System.EventHandler(this.radioButton_year_Click);
            // 
            // radioButton_mounth
            // 
            this.radioButton_mounth.AutoSize = true;
            this.radioButton_mounth.Location = new System.Drawing.Point(38, 55);
            this.radioButton_mounth.Name = "radioButton_mounth";
            this.radioButton_mounth.Size = new System.Drawing.Size(74, 22);
            this.radioButton_mounth.TabIndex = 1;
            this.radioButton_mounth.TabStop = true;
            this.radioButton_mounth.Text = "Месяц";
            this.radioButton_mounth.UseVisualStyleBackColor = true;
            this.radioButton_mounth.Click += new System.EventHandler(this.radioButton_mounth_Click);
            // 
            // radioButton_nedelya
            // 
            this.radioButton_nedelya.AutoSize = true;
            this.radioButton_nedelya.Location = new System.Drawing.Point(38, 32);
            this.radioButton_nedelya.Name = "radioButton_nedelya";
            this.radioButton_nedelya.Size = new System.Drawing.Size(80, 22);
            this.radioButton_nedelya.TabIndex = 0;
            this.radioButton_nedelya.TabStop = true;
            this.radioButton_nedelya.Text = "Неделя";
            this.radioButton_nedelya.UseVisualStyleBackColor = true;
            this.radioButton_nedelya.Click += new System.EventHandler(this.radioButton_nedelya_Click);
            // 
            // dateTimePicker_datarog
            // 
            this.dateTimePicker_datarog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_datarog.Location = new System.Drawing.Point(477, 46);
            this.dateTimePicker_datarog.Name = "dateTimePicker_datarog";
            this.dateTimePicker_datarog.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_datarog.TabIndex = 3;
            // 
            // checkBox_fiz
            // 
            this.checkBox_fiz.AutoSize = true;
            this.checkBox_fiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_fiz.Location = new System.Drawing.Point(477, 337);
            this.checkBox_fiz.Name = "checkBox_fiz";
            this.checkBox_fiz.Size = new System.Drawing.Size(111, 22);
            this.checkBox_fiz.TabIndex = 4;
            this.checkBox_fiz.Text = "Физическое";
            this.checkBox_fiz.UseVisualStyleBackColor = true;
            // 
            // checkBox_emo
            // 
            this.checkBox_emo.AutoSize = true;
            this.checkBox_emo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_emo.Location = new System.Drawing.Point(477, 365);
            this.checkBox_emo.Name = "checkBox_emo";
            this.checkBox_emo.Size = new System.Drawing.Size(145, 22);
            this.checkBox_emo.TabIndex = 5;
            this.checkBox_emo.Text = "Эмоциональное";
            this.checkBox_emo.UseVisualStyleBackColor = true;
            // 
            // checkBox_inte
            // 
            this.checkBox_inte.AutoSize = true;
            this.checkBox_inte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_inte.Location = new System.Drawing.Point(477, 393);
            this.checkBox_inte.Name = "checkBox_inte";
            this.checkBox_inte.Size = new System.Drawing.Size(151, 22);
            this.checkBox_inte.TabIndex = 6;
            this.checkBox_inte.Text = "Интеликтуальное";
            this.checkBox_inte.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(65, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Построить биоритмы человека";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(193, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Отчистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_datarog
            // 
            this.label_datarog.AutoSize = true;
            this.label_datarog.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_datarog.Location = new System.Drawing.Point(473, 19);
            this.label_datarog.Name = "label_datarog";
            this.label_datarog.Size = new System.Drawing.Size(158, 24);
            this.label_datarog.TabIndex = 9;
            this.label_datarog.Text = "Дата рождения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.label_datarog);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox_inte);
            this.Controls.Add(this.checkBox_emo);
            this.Controls.Add(this.checkBox_fiz);
            this.Controls.Add(this.dateTimePicker_datarog);
            this.Controls.Add(this.groupBox_period);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart_dan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_dan)).EndInit();
            this.groupBox_period.ResumeLayout(false);
            this.groupBox_period.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.DateTimePicker dateTimePicker_per1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_per2;
        private System.Windows.Forms.RadioButton radioButton_period;
        private System.Windows.Forms.RadioButton radioButton_year;
        private System.Windows.Forms.RadioButton radioButton_mounth;
        private System.Windows.Forms.RadioButton radioButton_nedelya;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datarog;
        private System.Windows.Forms.CheckBox checkBox_fiz;
        private System.Windows.Forms.CheckBox checkBox_emo;
        private System.Windows.Forms.CheckBox checkBox_inte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_datarog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_dan;
    }
}

