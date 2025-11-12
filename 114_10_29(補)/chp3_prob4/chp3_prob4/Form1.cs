using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chp3_prob4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 讀取並驗證輸入（若 standard_deductionTextBox / other_exemptionsTextBox 為空視為 0）
            if (!decimal.TryParse(annualtotal_incomeTextBox.Text.Trim(), out decimal totalIncome))
            {
                MessageBox.Show("請輸入有效的年度總收入數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal standardDeduction = 0m;
            decimal otherExemptions = 0m;

            if (!string.IsNullOrWhiteSpace(standard_deductionTextBox.Text) &&
                !decimal.TryParse(standard_deductionTextBox.Text.Trim(), out standardDeduction))
            {
                MessageBox.Show("請輸入有效的標準扣除額數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(other_exemptionsTextBox.Text) &&
                !decimal.TryParse(other_exemptionsTextBox.Text.Trim(), out otherExemptions))
            {
                MessageBox.Show("請輸入有效的其他免稅額數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (totalIncome < 0 || standardDeduction < 0 || otherExemptions < 0)
            {
                MessageBox.Show("各項金額不得為負。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 計算淨收入與稅額（稅率 15%）
            decimal netIncome = totalIncome - standardDeduction - otherExemptions;
            if (netIncome < 0m) netIncome = 0m;

            const decimal taxRate = 0.15m;
            decimal tax = Math.Round(netIncome * taxRate, 2);

            // 顯示結果（以系統文化顯示貨幣格式）
            total_incomeLabel.Text = totalIncome.ToString("C2");
            net_incomeLabel.Text = netIncome.ToString("C2");
            taxable_incomeLabel.Text = tax.ToString("C2");
        }

        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
