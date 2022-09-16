using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace биоритма
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dateTimePicker_per1.Visible = false;
            this.dateTimePicker_per2.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.radioButton_nedelya.Checked = false;
            this.radioButton_mounth.Checked = false;
            this.radioButton_year.Checked = false;
            this.radioButton_period.Checked = false;
            this.checkBox_fiz.Checked = false;
            this.checkBox_emo.Checked = false;
            this.checkBox_inte.Checked = false;
            this.chart_dan.Series[0].Points.Clear();
            this.chart_dan.Series[1].Points.Clear();
            this.chart_dan.Series[2].Points.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton_nedelya.Checked == false & radioButton_mounth.Checked == false & radioButton_year.Checked == false & radioButton_period.Checked == false)
            {
                MessageBox.Show(" не выбрали период");
                return;
            }
            if (checkBox_fiz.Checked == false & checkBox_emo.Checked == false & checkBox_inte.Checked == false)
            {
                MessageBox.Show(" не выбрали легенду");
                return;
            }
            DateTime dt_rog, dt_tek;
            TimeSpan delta, d;
            int k, n = 0, i;
            double yf, ye, yi;
            dt_tek = DateTime.Today;
            dt_rog = this.dateTimePicker_datarog.Value;
            delta = dt_tek - dt_rog;
            k = delta.Days;
            if (this.radioButton_nedelya.Checked) n = 7;
            if (this.radioButton_year.Checked) n = 365;
            if (this.radioButton_mounth.Checked) n = 30;
            if (this.radioButton_period.Checked)
            {
                d = this.dateTimePicker_per2.Value - dateTimePicker_per1.Value;
                n = (int)d.Days;
            }
            this.chart_dan.Series[0].Points.Clear();
            this.chart_dan.Series[1].Points.Clear();
            this.chart_dan.Series[2].Points.Clear();
            this.chart_dan.Visible = false;

            for (i = 1; i <= n; i++)
            {
                yf = Math.Sin(2 * Math.PI * (k + i) / 23.0);
                if (this.checkBox_fiz.Checked == true)
                    this.chart_dan.Series[0].Points.AddXY(i, yf);

                ye = Math.Sin(2 * Math.PI * (k + i) / 28.0);
                if (this.checkBox_emo.Checked == true)
                    this.chart_dan.Series[1].Points.AddXY(i, ye);

                yi = Math.Sin(2 * Math.PI * (k + i) / 33.0);
                if (this.checkBox_inte.Checked == true)
                    this.chart_dan.Series[2].Points.AddXY(i, yi);

            }

            this.chart_dan.Visible = true;
        }

        private void radioButton_period_Click_1(object sender, EventArgs e)
        {
            this.dateTimePicker_per1.Visible = true;
            this.dateTimePicker_per2.Visible = true;
        }

        private void radioButton_year_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_per1.Visible = false;
            this.dateTimePicker_per2.Visible = false;
        }

        private void radioButton_mounth_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_per1.Visible = false;
            this.dateTimePicker_per2.Visible = false;
        }

        private void radioButton_nedelya_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_per1.Visible = false;
            this.dateTimePicker_per2.Visible = false;
        }
    }
}
