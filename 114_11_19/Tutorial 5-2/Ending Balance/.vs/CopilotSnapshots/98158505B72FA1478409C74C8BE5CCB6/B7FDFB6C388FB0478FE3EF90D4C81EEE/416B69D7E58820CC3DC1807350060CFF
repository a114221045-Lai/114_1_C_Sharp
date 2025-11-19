using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 每月利率常數（此處為 0.5% / 月）
            const decimal INTEREST_RATE = 0.005m; // 每月利率

            // 宣告變數：balance 儲存目前結餘，months 儲存月份數
            decimal balance;
            int months;

            // 清除明細清單，避免顯示舊有結果
            detailListBox.Items.Clear();

            // 驗證並解析起始餘額（從 TextBox 的 Text 屬性讀取）
            // 使用 TryParse 可避免引發例外，若解析失敗則提示使用者
            if (!decimal.TryParse(startingBalTextBox.Text.Trim(), out balance))
            {
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startingBalTextBox.Focus();
                return;
            }

            // 驗證並解析月份輸入（必須為正整數）
            if (!int.TryParse(monthsTextBox.Text.Trim(), out months) || months < 1)
            {
                MessageBox.Show("請輸入有效的月份數（至少 1）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthsTextBox.Focus();
                return;
            }

            // 逐月計算利息並將明細加入 ListBox
            for (int count = 1; count <= months; count++)
            {
                // 計算本月利息，四捨五入到小數點後兩位（貨幣精度）
                decimal interest = Math.Round(balance * INTEREST_RATE, 2);

                // 將利息加入結餘
                balance += interest;

                // 將本月明細加入 ListBox，顯示月數、利息與更新後的結餘
                string detail = string.Format("第 {0} 個月：利息 {1}，結餘 {2}",
                    count, interest.ToString("C2"), balance.ToString("C2"));

                detailListBox.Items.Add(detail);
            }

            // 計算完成後，顯示最終結餘於標籤（以貨幣格式呈現）
            endingBalanceLabel.Text = balance.ToString("C2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
