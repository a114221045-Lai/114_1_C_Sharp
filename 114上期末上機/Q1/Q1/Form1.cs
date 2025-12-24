using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        // 電腦與玩家選擇：0=石頭, 1=布, 2=剪刀
        private int _computerChoice;
        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
            // 初始化 UI 狀態
        }
        private void stoneButton_Click(object sender, EventArgs e)
        {

        }

        private void paperButton_Click(object sender, EventArgs e)
        {

        }

        private void scissorButton_Click(object sender, EventArgs e)
        {

        }



        private void getCompChoice()
        {
            // 0=石頭, 1=布, 2=剪刀
            _computerChoice = _random.Next(0, 3);
        }

        private void showComputerImage() 
        {
            
        }

        private void showPlayerImage()
        {

        }

        private void showWinner()
        {
           
        }
    }
    
}
