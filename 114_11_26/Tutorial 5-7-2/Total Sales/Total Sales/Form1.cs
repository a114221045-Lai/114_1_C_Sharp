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
using System.Diagnostics.Eventing.Reader;

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
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行                        

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 開啟檔案
                inputFile = File.OpenText(openFileDialog1.FileName);
                salesListBox.Items.Clear();

                // 讀取檔案直到結尾
                while (!inputFile.EndOfStream)
                {
                    // 讀取一行並轉換為十進位數
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && decimal.TryParse(parts[1], out currentSales))
                    {
                        // 將銷售額加入清單框
                        salesListBox.Items.Add(parts[0] + ": " + currentSales.ToString("c"));
                        // 將目前銷售額加到總銷售額
                        totalSales += currentSales;
                    }

                }
                // 關閉檔案
                inputFile.Close();
                // 顯示總銷售額
                totalLabel.Text = "Total Sales: " + totalSales.ToString("c");

                // 顯示額外的彈窗
                MessageBox.Show("哈哈完蛋了，完全不知道怎麼改");
            }
            else
            {
                MessageBox.Show("未選擇檔案。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}


