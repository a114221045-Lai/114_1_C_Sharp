namespace chp3_prob4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.annualtotal_incomeTextBox = new System.Windows.Forms.TextBox();
            this.standard_deductionTextBox = new System.Windows.Forms.TextBox();
            this.other_exemptionsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total_incomeLabel = new System.Windows.Forms.Label();
            this.net_incomeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.taxable_incomeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "年度總收入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(75, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "標準扣除額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(75, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "其他免稅額";
            // 
            // annualtotal_incomeTextBox
            // 
            this.annualtotal_incomeTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.annualtotal_incomeTextBox.Location = new System.Drawing.Point(475, 86);
            this.annualtotal_incomeTextBox.Name = "annualtotal_incomeTextBox";
            this.annualtotal_incomeTextBox.Size = new System.Drawing.Size(201, 65);
            this.annualtotal_incomeTextBox.TabIndex = 3;
            // 
            // standard_deductionTextBox
            // 
            this.standard_deductionTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.standard_deductionTextBox.Location = new System.Drawing.Point(475, 169);
            this.standard_deductionTextBox.Name = "standard_deductionTextBox";
            this.standard_deductionTextBox.Size = new System.Drawing.Size(201, 65);
            this.standard_deductionTextBox.TabIndex = 4;
            // 
            // other_exemptionsTextBox
            // 
            this.other_exemptionsTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.other_exemptionsTextBox.Location = new System.Drawing.Point(475, 247);
            this.other_exemptionsTextBox.Name = "other_exemptionsTextBox";
            this.other_exemptionsTextBox.Size = new System.Drawing.Size(201, 65);
            this.other_exemptionsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(76, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "總收入";
            // 
            // total_incomeLabel
            // 
            this.total_incomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_incomeLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.total_incomeLabel.Location = new System.Drawing.Point(475, 382);
            this.total_incomeLabel.Name = "total_incomeLabel";
            this.total_incomeLabel.Size = new System.Drawing.Size(270, 61);
            this.total_incomeLabel.TabIndex = 7;
            // 
            // net_incomeLabel
            // 
            this.net_incomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.net_incomeLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.net_incomeLabel.Location = new System.Drawing.Point(475, 464);
            this.net_incomeLabel.Name = "net_incomeLabel";
            this.net_incomeLabel.Size = new System.Drawing.Size(270, 61);
            this.net_incomeLabel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(75, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 48);
            this.label7.TabIndex = 8;
            this.label7.Text = "淨收入";
            // 
            // taxable_incomeLabel
            // 
            this.taxable_incomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxable_incomeLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.taxable_incomeLabel.Location = new System.Drawing.Point(475, 542);
            this.taxable_incomeLabel.Name = "taxable_incomeLabel";
            this.taxable_incomeLabel.Size = new System.Drawing.Size(270, 61);
            this.taxable_incomeLabel.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(75, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 48);
            this.label9.TabIndex = 10;
            this.label9.Text = "應繳所得稅";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(89, 687);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(202, 64);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(513, 687);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(202, 64);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 787);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.taxable_incomeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.net_incomeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total_incomeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.other_exemptionsTextBox);
            this.Controls.Add(this.standard_deductionTextBox);
            this.Controls.Add(this.annualtotal_incomeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "所得稅計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox annualtotal_incomeTextBox;
        private System.Windows.Forms.TextBox standard_deductionTextBox;
        private System.Windows.Forms.TextBox other_exemptionsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_incomeLabel;
        private System.Windows.Forms.Label net_incomeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label taxable_incomeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

