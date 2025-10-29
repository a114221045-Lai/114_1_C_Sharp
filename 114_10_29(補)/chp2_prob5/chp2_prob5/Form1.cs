using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp2_prob5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 將按鈕的 Click 事件接到對應的處理函式（Designer 未自動連結的）
            this.button2.Click += button2_Click;
            this.exitbutton.Click += exitbutton_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 顯示人頭圖，隱藏數字(尾)圖
            this.HeadpictureBox.Visible = true;
            this.TailspictureBox.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 顯示數字(尾)圖，隱藏人頭圖
            this.HeadpictureBox.Visible = false;
            this.TailspictureBox.Visible = true;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
