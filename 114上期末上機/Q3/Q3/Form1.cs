using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        private int[] generatedNumbers = null; // 儲存產生的號碼
        private List<int> drawNumbersCache = new List<int>(); // 快取開獎號碼供重複比對

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 「產生號碼」按鈕點擊事件處理器
        /// 當使用者點擊「產生號碼」按鈕時觸發此方法
        /// 負責產生五個隨機的彩券號碼並顯示在標籤上
        /// </summary>
        private void generateButton_Click(object sender, EventArgs e)
        {
            // 建立隨機數生成器
            const int SIZE = 5;
            // 彩券號碼數量
            generatedNumbers = new int[SIZE];
            Label[] labels = new Label[SIZE] { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };

            Random random = new Random();

            // 產生五個隨機號碼（避免重複）
            for (int i = 0; i < SIZE; i++)
            {
                int temp;
                bool isDuplicate;

                do
                {
                    temp = random.Next(1, 50); // 產生 1 到 49 的隨機數
                    isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (generatedNumbers[j] == temp)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                }
                while (isDuplicate);

                generatedNumbers[i] = temp;
            }

            // 顯示產生的號碼在標籤上
            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = generatedNumbers[i].ToString();
            }

            // 若已有開獎號碼快取，則無限次比對
            if (drawNumbersCache != null && drawNumbersCache.Count > 0)
            {
                CompareNumbers(drawNumbersCache);
            }
            else if (drawNumbersListBox.Items.Count > 0)
            {
                // 退而求其次：從 ListBox 解析數字再比對
                List<int> drawNumbers = new List<int>();
                foreach (var item in drawNumbersListBox.Items)
                {
                    string text = item != null ? item.ToString().Trim() : string.Empty;
                    if (int.TryParse(text, out int n))
                    {
                        drawNumbers.Add(n);
                    }
                }
                if (drawNumbers.Count > 0)
                {
                    drawNumbersCache = drawNumbers; // 同步到快取
                    CompareNumbers(drawNumbers);
                }
                else
                {
                    resultLabel.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// 「開獎號碼」按鈕點擊事件處理器
        /// 當使用者點擊「開獎號碼」按鈕時觸發此方法
        /// 功能：處理檔案選擇與讀取開獎號碼的流程
        /// </summary>
        private void drawButton_Click(object sender, EventArgs e)
        {
            // 建立檔案開啟對話框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog.Title = "選擇開獎號碼檔案";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 清空ListBox和結果顯示區域
                    drawNumbersListBox.Items.Clear();
                    resultLabel.Text = "";

                    // 使用 StreamReader 讀取檔案
                    string filePath = openFileDialog.FileName;
                    List<int> drawNumbers = new List<int>();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string trimmed = line.Trim();

                            // 無論內容為何，先在 ListBox 顯示原始行
                            drawNumbersListBox.Items.Add(trimmed);

                            // 僅將可解析為整數的行加入比對集合
                            if (int.TryParse(trimmed, out int number))
                            {
                                drawNumbers.Add(number);
                            }
                        }
                    }

                    // 更新快取以便之後無限次比對
                    drawNumbersCache = drawNumbers;

                    // 先開獎後對獎：若已產生號碼則立即比對；尚未產生則僅顯示開獎號碼
                    if (generatedNumbers != null && generatedNumbers.Length > 0)
                    {
                        CompareNumbers(drawNumbersCache);
                    }
                    // 若尚未產生號碼，不提示、不比對，等待使用者之後按下「產生號碼」
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案出錯: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 比對產生的號碼和開獎號碼
        /// </summary>
        private void CompareNumbers(List<int> drawNumbers)
        {
            List<int> matchedNumbers = new List<int>();

            // 檢查產生的號碼中有多少個在開獎號碼中
            foreach (int num in generatedNumbers)
            {
                if (drawNumbers.Contains(num))
                {
                    matchedNumbers.Add(num);
                }
            }

            // 構建結果文字
            StringBuilder resultText = new StringBuilder();
            
            if (matchedNumbers.Count == 0)
            {
                resultText.AppendLine("比對結果：");
                resultText.AppendLine();
                resultText.AppendLine("中0個號碼");
                resultText.AppendLine();
                resultText.AppendLine("⊗ 沒中獎");
            }
            else
            {
                resultText.AppendLine("比對結果：");
                resultText.AppendLine();
                resultText.AppendLine($"中{matchedNumbers.Count}個號碼");
                resultText.AppendLine();
                resultText.AppendLine("中獎號碼: ");
                // 將中獎號碼用逗號分隔顯示
                resultText.Append(string.Join(", ", matchedNumbers));
            }

            resultLabel.Text = resultText.ToString();
        }

        /// <summary>
        /// 「離開」按鈕點擊事件處理器
        /// 當使用者點擊「離開」按鈕時觸發此方法
        /// 功能：關閉表單並結束程式執行
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

    }
}
