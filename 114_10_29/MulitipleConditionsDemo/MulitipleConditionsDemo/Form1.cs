using System;
using System.Windows.Forms;

namespace MulitipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            // 先移除輸入字串前後空白
            string input = textBoxScore.Text.Trim();
            if (int.TryParse(input, out int score))
            {
                string grade;
                if (score >= 90)
                {
                    if (score > 100)
                    {
                        MessageBox.Show("成績不能大於 100 分。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else grade = "A";
                }
                else if (score >= 80) //score 小於 90是隱含的條件
                {
                    grade = "B";
                }
                else if (score >= 70) //score 小於 80是隱含的條件
                {
                    grade = "C";
                }
                else if (score >= 60)  //score 小於 70是隱含的條件
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }

                // 正確使用字串插值或組合字串，顯示等級於 labelGrade
                labelGrade.Text = grade;
            }
            else
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
