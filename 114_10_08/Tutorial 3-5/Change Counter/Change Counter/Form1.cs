using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENT = 5.0m;
        const decimal TEN_CENT = 10.0m;
        const decimal TWENTY_FIVE_CENT = 25.0m;
        const decimal FIFTY_CENT = 50.0m;
        
        
        private decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {

            decimal total = 0m;
            total += FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            
            total += TEN_CENT;
            totalLabel.Text = total.ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            
            total += TWENTY_FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            
            total += FIFTY_CENT;
            totalLabel.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
