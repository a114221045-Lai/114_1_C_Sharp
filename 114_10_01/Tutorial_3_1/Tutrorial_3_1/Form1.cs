using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutrorial_3_1
{
    public partial class BirthDateString : Form
    {
        public BirthDateString()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string output;

            output = "中華民國"+ YearTextBox.Text + "年 " +
              MonthTextBox.Text + "月 " +
              dayOfMonthTextBox.Text + "日 "
              + "星期" + dayOfWeekTextBox.Text;

            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            YearTextBox.Text = "" ;
            MonthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            dayOfWeekTextBox.Text = "";
            
            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





