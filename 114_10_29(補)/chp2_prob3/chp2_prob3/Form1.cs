using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp2_prob3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            namelabel.Text = "愛心九";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            namelabel.Text = "黑桃四";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            namelabel.Text = "菱形五";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            namelabel.Text = "梅花三";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            namelabel.Text = "大鬼";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
