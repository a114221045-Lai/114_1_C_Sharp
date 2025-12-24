using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        // 常數設定
        private const double OilChange = 780;       // 更換機油
        private const double LubeJob = 540;         // 潤滑保養
        private const double RadiatorFlush = 900;   // 水箱清洗
        private const double TransmissionFlush = 2400; // 變速箱清洗
        private const double Inspection = 450;      // 檢驗
        private const double MufflerReplacement = 3000; // 更換消音器
        private const double TireRotation = 600;    // 輪胎換位
        private const double LaborRatePerHour = 600; // 工資/時
        private const double TaxRate = 0.06;        // 零件稅率

        public Form1()
        {
            InitializeComponent();
        }

        // 事件：計算
        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay();
        }

        // 事件：清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        // 事件：離開
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 事件：儲存
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 先計算，確保欄位有最新金額
            if (!CalculateAndDisplay()) return; // 若輸入錯誤，終止

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "文字檔 (*.txt)|*.txt";
                sfd.FileName = "維修明細_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, BuildReport(), Encoding.UTF8);
                    MessageBox.Show("已儲存。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 計算與呈現
        private bool CalculateAndDisplay()
        {
            // 取得輸入
            if (!TryParseNonNegative(txtParts.Text, out double parts))
            {
                MessageBox.Show("零件金額請輸入非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParts.Focus();
                return false;
            }
            if (!TryParseNonNegative(txtHours.Text, out double hours))
            {
                MessageBox.Show("工時數請輸入非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHours.Focus();
                return false;
            }

            double serviceCharges = OilLubeCharges() + FlushCharges() + MiscCharges();
            double labor = hours * LaborRatePerHour;
            double serviceAndLabor = serviceCharges + labor;
            double partsTax = Math.Round(parts * TaxRate, 0, MidpointRounding.AwayFromZero); // 取整至元
            double total = serviceAndLabor + parts + partsTax;

            // 顯示
            txtServiceLabor.Text = FormatNtd(serviceAndLabor);
            txtPartsSummary.Text = FormatNtd(parts);
            txtTax.Text = FormatNtd(partsTax);
            txtTotal.Text = FormatNtd(total);

            return true;
        }

        private string FormatNtd(double value)
        {
            return "NT$" + value.ToString("#,0");
        }

        private bool TryParseNonNegative(string input, out double value)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                value = 0;
                return true;
            }
            bool ok = double.TryParse(input.Trim(), out value);
            if (!ok || value < 0)
            {
                value = 0;
                return false;
            }
            return true;
        }

        private double OilLubeCharges()
        {
            double sum = 0;
            if (cbOil.Checked) sum += OilChange;
            if (cbLube.Checked) sum += LubeJob;
            return sum;
        }

        private double FlushCharges()
        {
            double sum = 0;
            if (cbRadiatorFlush.Checked) sum += RadiatorFlush;
            if (cbTransFlush.Checked) sum += TransmissionFlush;
            return sum;
        }

        private double MiscCharges()
        {
            double sum = 0;
            if (cbInspection.Checked) sum += Inspection;
            if (cbMuffler.Checked) sum += MufflerReplacement;
            if (cbTireRotation.Checked) sum += TireRotation;
            return sum;
        }

        private void ClearAll()
        {
            // 取消勾選
            cbOil.Checked = false;
            cbLube.Checked = false;
            cbRadiatorFlush.Checked = false;
            cbTransFlush.Checked = false;
            cbInspection.Checked = false;
            cbMuffler.Checked = false;
            cbTireRotation.Checked = false;

            // 清空輸入/輸出
            txtParts.Text = string.Empty;
            txtHours.Text = string.Empty;
            txtServiceLabor.Text = string.Empty;
            txtPartsSummary.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;

            txtParts.Focus();
        }

        private string BuildReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine("汽車維修服務 明細");
            sb.AppendLine(new string('-', 24));
            sb.AppendLine("日期時間: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            sb.AppendLine();

            // 服務項目
            sb.AppendLine("[機油和潤滑]");
            if (cbOil.Checked) sb.AppendLine("- 更換機油: " + FormatNtd(OilChange));
            if (cbLube.Checked) sb.AppendLine("- 潤滑保養: " + FormatNtd(LubeJob));
            sb.AppendLine("[清洗服務]");
            if (cbRadiatorFlush.Checked) sb.AppendLine("- 水箱清洗: " + FormatNtd(RadiatorFlush));
            if (cbTransFlush.Checked) sb.AppendLine("- 變速箱清洗: " + FormatNtd(TransmissionFlush));
            sb.AppendLine("[其他服務]");
            if (cbInspection.Checked) sb.AppendLine("- 檢驗: " + FormatNtd(Inspection));
            if (cbMuffler.Checked) sb.AppendLine("- 更換消音器: " + FormatNtd(MufflerReplacement));
            if (cbTireRotation.Checked) sb.AppendLine("- 輪胎換位: " + FormatNtd(TireRotation));
            sb.AppendLine();

            // 輸入
            double.TryParse(string.IsNullOrWhiteSpace(txtParts.Text) ? "0" : txtParts.Text.Trim(), out double parts);
            double.TryParse(string.IsNullOrWhiteSpace(txtHours.Text) ? "0" : txtHours.Text.Trim(), out double hours);

            double serviceCharges = OilLubeCharges() + FlushCharges() + MiscCharges();
            double labor = hours * LaborRatePerHour;
            double serviceAndLabor = serviceCharges + labor;
            double partsTax = Math.Round(parts * TaxRate, 0, MidpointRounding.AwayFromZero);
            double total = serviceAndLabor + parts + partsTax;

            sb.AppendLine("工時: " + hours.ToString("0.##") + " 小時 (" + FormatNtd(LaborRatePerHour) + "/時): " + FormatNtd(labor));
            sb.AppendLine();

            sb.AppendLine("[費用摘要]");
            sb.AppendLine("服務與工資: " + FormatNtd(serviceAndLabor));
            sb.AppendLine("零件: " + FormatNtd(parts));
            sb.AppendLine("稅金(零件): " + FormatNtd(partsTax));
            sb.AppendLine("總費用: " + FormatNtd(total));

            return sb.ToString();
        }
    }
}
