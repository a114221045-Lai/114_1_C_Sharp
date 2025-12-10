using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    // 主表單 (Form1) 的部分實作
    // 此檔案保留事件處理器與程式邏輯，並加入繁體中文註解說明用途與行為。
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件 (由 Designer 產生的 InitializeComponent)
        public Form1()
        {
            InitializeComponent();
        }

        // 顯示撲克牌的按鈕事件處理器
        // 使用者按下「顯示撲克牌」按鈕時會觸發此方法。
        // 目前此處保留空實作，實際要顯示哪張牌請在此處加入邏輯。
        private void showCardButton_Click(object sender, EventArgs e)
        {
           if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard (cardListBox.SelectedItem.ToString());
            }
           else
            {
               MessageBox.Show("請先選擇一張撲克牌。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void showSelectedCard(string cardName)
        {
            switch(cardName)
            {
                case "黑桃A":
                    showAceSpades();
                    break;
                case "紅心10":
                    showTenHearts();
                    break;
                case "梅花K":
                    showKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的撲克牌名稱。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        // 離開按鈕事件處理器
        // 使用者按下「離開」按鈕時，關閉目前表單 (結束應用程式視窗)
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
