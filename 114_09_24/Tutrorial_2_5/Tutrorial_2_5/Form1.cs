using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutrorial_2_5
{
    // 主視窗類別
    public partial class Form1 : Form
    {
        // 建構函式，初始化元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 顯示卡背按鈕的事件處理函式
        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardFacePictureBox.Visible = false; // 隱藏卡牌正面
            cardBackPictureBox.Visible = true;  // 顯示卡牌背面
        }

        // 顯示卡面按鈕的事件處理函式
        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardFacePictureBox.Visible = true;  // 顯示卡牌正面
            cardBackPictureBox.Visible = false; // 隱藏卡牌背面
        }
    }
}
