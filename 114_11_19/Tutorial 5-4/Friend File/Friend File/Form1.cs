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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {                 // 取得使用者輸入的名字。
                string friendName = nameTextBox.Text;
                // 開啟檔案以附加模式寫入。
                StreamWriter outputFile;

                outputFile = File.AppendText("Friends.txt");

                // 將名字寫入檔案。
                outputFile.WriteLine(nameTextBox.Text);

                // 關閉檔案。
                outputFile.Close();

                // 清除文字方塊以便輸入下一個名字。
                nameTextBox.Clear();
                nameTextBox.Focus();
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
