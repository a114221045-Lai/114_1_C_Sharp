using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp3_prob4
{
    public partial class Form1 : Form
    {
        private const decimal TaxRate = 0.15m; // 15%

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // 讀取並驗證使用者輸入
            if (!decimal.TryParse(textBoxTotalIncome.Text.Trim(), out decimal totalIncome))
            {
                MessageBox.Show("請輸入有效的年度總收入數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTotalIncome.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxStandardDeduction.Text.Trim(), out decimal standardDeduction))
            {
                MessageBox.Show("請輸入有效的標準扣除額數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStandardDeduction.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxOtherExemptions.Text.Trim(), out decimal otherExemptions))
            {
                MessageBox.Show("請輸入有效的其他免稅額數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOtherExemptions.Focus();
                return;
            }

            // 計算淨收入
            decimal netIncome = totalIncome - standardDeduction - otherExemptions;
            if (netIncome < 0) netIncome = 0;

            // 計算應繳稅額
            decimal tax = Math.Round(netIncome * TaxRate, 2);

            // 顯示結果
            labelResultTotal.Text = $"總收入：{totalIncome:C2}";
            labelResultNet.Text = $"淨收入：{netIncome:C2}";
            labelResultTax.Text = $"應繳稅額：{tax:C2}";
        }
    }
}
