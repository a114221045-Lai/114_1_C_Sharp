using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                // 讀取銷售數據並計算總銷售額
                decimal sales;
                decimal total = 0;

                // 打開文件
                StreamReader inputFile;

                // 假設銷售數據存儲在 Sales.txt 文件中，每行一個銷售額
                inputFile = File.OpenText("Sales.txt");

                // 讀取數據並計算總和
                while (!inputFile.EndOfStream)
                {
                    // 讀取每行銷售額
                    sales = decimal.Parse(inputFile.ReadLine());

                    // 累加到總銷售額
                    total += sales;

                    //將每行銷售額顯示在列表框中
                    listBox1.Items.Add(sales.ToString("C"));
                }

                // 關閉文件
                inputFile.Close();

                // 顯示總銷售額
                totalLabel.Text = total.ToString("C");

                //將每行銷售額顯示在列表框中
                listBox1.Items.Add("總銷售額: " + total.ToString("C"));
            }
            catch (Exception ex)
            {
                // 顯示錯誤信息
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
