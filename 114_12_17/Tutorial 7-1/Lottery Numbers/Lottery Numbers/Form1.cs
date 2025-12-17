using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    /// <summary>
    /// 彩券號碼產生器主要表單類別
    /// 此表單提供使用者產生隨機彩券號碼的功能
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1 建構子
        /// 初始化表單元件
        /// </summary>
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
            int[] lotteryNumbers = new int[SIZE];
            /*********************************************
             * 在此產生樂透號碼並指派給 lotteryNumbers 陣列 *
             ****************************************/
            Label[] labels = new Label[SIZE] { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };

            Random random = new Random();

            // 產生五個隨機號碼
            for (int i = 0; i < SIZE; i++)
            {
                int temp;
                bool isDuplicate;

                do
                {
                    temp = random.Next(1, 50); // 產生 1 到 49 的隨機數
                    isDuplicate = false;
                    // 檢查是否有重複號碼
                    for (int j = 0; j < i; j++)
                    {
                        if (lotteryNumbers[j] == temp)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                }
                while (isDuplicate);

                lotteryNumbers[i] = temp;
            }
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            // 顯示產生的號碼在標籤上
            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }

        }

        /// <summary>
        /// 「結束」按鈕點擊事件處理器
        /// 當使用者點擊「結束」按鈕時觸發此方法
        /// 功能：關閉表單並結束程式執行
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
