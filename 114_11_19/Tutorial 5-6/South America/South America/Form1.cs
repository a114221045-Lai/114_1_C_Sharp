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
using System.Linq.Expressions;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                // 用來儲存從檔案讀取的國家名稱。
                string countryName;

                // 使用 StreamReader 物件來讀取文字檔。
                StreamReader inputFile;

                // 開啟包含南美洲國家名稱的文字檔。
                inputFile = File.OpenText("Countries.txt");

                // 讀取檔案直到結尾。
                while (!inputFile.EndOfStream)
                {
                    // 讀取一行並將其存入 countryName 變數。
                    countryName = inputFile.ReadLine();

                    // 將 countryName 加入到清單方塊中。
                    countriesListBox.Items.Add(countryName);
                }

                // 關閉檔案。
                inputFile.Close();
            }
        
        
            catch (Exception ex)
            {
                    // 顯示錯誤訊息。
                    MessageBox.Show(ex.Message);
            }
        }

    private void exitButton_Click(object sender, EventArgs e)
            {
                // 關閉表單。
                this.Close();
            }
    }
}
