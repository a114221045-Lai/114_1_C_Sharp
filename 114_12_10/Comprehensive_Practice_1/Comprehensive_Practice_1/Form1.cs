using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    // 主窗體類別：負責 UI 事件處理與商業邏輯（例如計算最高分）
    public partial class Form1 : Form
    {
        // 建構子：初始化元件（由 Designer 產生的 InitializeComponent）
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnShowHighest_Click(object sender, EventArgs e)
        {
            string surname = txtFirstName.Text;
            string givenName = txtLastName.Text;

            int quiz1, quiz2, quiz3;
            if(int.TryParse(txtQuiz1.Text, out quiz1)&&
               int.TryParse(txtQuiz2.Text, out quiz2)&&
               int.TryParse(txtQuiz3.Text, out quiz3))
            {
                showResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("請輸入有效的分數（整數）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
           
        }

        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore;
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }
            lblResult.Text = string.Format("{0} {1} 的最高分是 {2} 分", surname, givenName, highestScore);
        }

        // 清除所有輸入框的內容
        private void clearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtFirstName.Focus(); // 將焦點設回第一個輸入框
        }


        // btnExit_Click: 關閉目前表單（結束應用程式視窗）
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close() 會觸發表單的關閉程序與相關資源釋放
            this.Close();
        }
    }
}
