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

namespace North_America
{
    /// <summary>
    /// Form1 是北美洲國家應用程式的主表單。
    /// 此表單允許使用者從指定的檔案中取得並顯示北美洲國家的清單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化 Form1 的新執行個體。
        /// 呼叫 InitializeComponent 方法以設定所有表單控制項。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GetFileName 方法從使用者那裡取得檔案名稱，
        /// 並將其指派給作為引數傳遞的變數。
        /// 此方法通常與 OpenFileDialog 搭配使用以取得檔案路徑。
        /// </summary>

        /// <summary>
        /// GetCountries 方法接受檔案名稱作為引數。
        /// 此方法開啟指定的檔案，並在 countriesListBox 控制項中顯示其內容。
        /// 每一行應包含一個北美洲國家的名稱。
        /// </summary>

        /// <summary>
        /// getCountriesButton_Click 事件處理程式
        /// 當使用者按一下「取得國家」按鈕時觸發此事件。
        /// 此方法應顯示檔案選取對話框，並載入選取的檔案中的國家清單。
        /// </summary>
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            // 取得檔案名稱。
            GetFileName(out fileName);
            // 取得並顯示國家清單。
            GetCountries(fileName);
        }

        private void GetFileName(out string fileName)
        {
            // 顯示開啟檔案對話框，讓使用者選取檔案。
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 將選取的檔案名稱指派給輸出參數。
                fileName = openFile.FileName;
            }
            else
            {
                // 如果使用者取消選取，將檔案名稱設為空字串。
                fileName = string.Empty;
            }
        }

        private void GetCountries(string fileName)
        {
            string country;
            // 清除現有的國家清單。
            countriesListBox.Items.Clear();
            // 檢查檔案名稱是否為空。
            if (fileName != string.Empty)
            {
                // 使用 StreamReader 開啟指定的檔案。
                StreamReader inputFile = File.OpenText(fileName);
                // 逐行讀取檔案內容，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    // 讀取一行並將其指派給 country 變數。
                    country = inputFile.ReadLine();
                    // 將讀取的國家名稱新增到 countriesListBox 控制項中。
                    countriesListBox.Items.Add(country);
                }
                // 關閉檔案。
                inputFile.Close();
            }
            else
            {
                // 顯示錯誤訊息，表示未選取檔案。
                MessageBox.Show("未選取檔案。");
            }
        }

        /// <summary>
        /// exitButton_Click 事件處理程式
        /// 當使用者按一下「退出」按鈕時觸發此事件。
        /// 此方法會關閉表單和應用程式。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

    }
}
