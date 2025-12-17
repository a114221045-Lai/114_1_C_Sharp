using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    // 薪資和獎金計算器表單
    // 此表單用於計算員工的退休貢獻金
    // 退休貢獻金 = (總薪資 + 獎金金額) × 貢獻率(5%)
    public partial class Form1 : Form
    {
        // 常數欄位，定義退休貢獻率為5%
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid方法用於將使用者輸入轉換為十進制數值
        // 並將結果存儲在引用參數中
        // 如果轉換成功，返回true；否則返回false


        // 計算按鈕的點擊事件處理程序
        // 功能：驗證輸入資料、計算退休貢獻金、顯示結果
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay;
            decimal bonus;
            decimal bonusAmount;
            // 驗證輸入資料
            if (InputIsValid(out grossPay, out bonus))
            {
                // 計算退休貢獻金
                bonusAmount = (grossPay + bonus) * CONTRIB_RATE;
                // 顯示結果，格式化為貨幣形式
                contributionLabel.Text = bonusAmount.ToString("C");
            }
        }
        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            bool inputIsValid = false;
            // 嘗試將輸入轉換為十進制數值
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputIsValid = true;
                }
                else
                {
                    MessageBox.Show("請輸入有效的獎金金額。", "輸入錯誤");
                    //inputIsValid = false;
                    grossPay = 0;
                    bonus = 0;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的總薪資。", "輸入錯誤");
                //inputIsValid = false;
                grossPay = 0;
                bonus = 0;
            }
            return inputIsValid;
        }

        // 結束按鈕的點擊事件處理程序
        // 功能：關閉表單，結束應用程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
