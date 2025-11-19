using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp3_prob10
{
    public partial class Form1 : Form
    {
        // 新增：以整數變數儲存累計卡路里
        private int totalCaloriesSum = 0;

        public Form1()
        {
            InitializeComponent();
            // 確保 TextBox 顯示初始值（Designer 已設定為 "0"，這裡做同步）
            totalCalories.Text = totalCaloriesSum.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCaloriesSum += 115;
            totalCalories.Text = totalCaloriesSum.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalCaloriesSum += 80;
            totalCalories.Text = totalCaloriesSum.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalCaloriesSum += 90;
            totalCalories.Text = totalCaloriesSum.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCaloriesSum += 120;
            totalCalories.Text = totalCaloriesSum.ToString();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            totalCaloriesSum = 0;
            totalCalories.Text = "0";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
