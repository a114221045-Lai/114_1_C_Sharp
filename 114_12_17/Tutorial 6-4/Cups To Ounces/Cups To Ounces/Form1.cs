using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法接受杯子數量作為參數
        // 並返回等效的流體盎司數量
        // 轉換公式：1杯 = 8流體盎司
     

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups;
            double ounces;

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // 呼叫 CupsToOunces 方法進行轉換
                ounces = CupsToOunces(cups);
                // 顯示結果，格式化為兩位小數
                ouncesLabel.Text = ounces.ToString("F2") + " 流體盎司";
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CupsToOunces(double cups)
        {
            // 每杯等於8流體盎司
            double ounces = cups * 8;
            return ounces;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 結束按鈕點擊事件處理程序
            // 關閉表單並結束應用程式
            this.Close();
        }
    }
}
