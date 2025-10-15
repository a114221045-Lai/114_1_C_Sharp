namespace Loan_Qualifier
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計產生的程式碼

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿以程式碼編輯器修改
        /// </summary>
        private void InitializeComponent()
        {
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.salaryPromptLabel.Location = new System.Drawing.Point(223, 51);
            this.salaryPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(128, 45);
            this.salaryPromptLabel.TabIndex = 0;
            this.salaryPromptLabel.Text = "年薪：";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.AutoSize = true;
            this.yearsPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.yearsPromptLabel.Location = new System.Drawing.Point(151, 157);
            this.yearsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(200, 45);
            this.yearsPromptLabel.TabIndex = 1;
            this.yearsPromptLabel.Text = "現職年資：";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.salaryTextBox.Location = new System.Drawing.Point(446, 41);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(332, 55);
            this.salaryTextBox.TabIndex = 2;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.yearsTextBox.Location = new System.Drawing.Point(446, 147);
            this.yearsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(148, 55);
            this.yearsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(79, 268);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(272, 45);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "貸款審核結果：";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.decisionLabel.Location = new System.Drawing.Point(446, 256);
            this.decisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(542, 64);
            this.decisionLabel.TabIndex = 5;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.checkButton.Location = new System.Drawing.Point(151, 383);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(213, 65);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "檢查資格";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.clearButton.Location = new System.Drawing.Point(491, 383);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(132, 65);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.exitButton.Location = new System.Drawing.Point(824, 383);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 65);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 500);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "貸款資格審核";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 表單元件宣告區
        private System.Windows.Forms.Label salaryPromptLabel;      // 年薪標籤
        private System.Windows.Forms.Label yearsPromptLabel;       // 現職年資標籤
        private System.Windows.Forms.TextBox salaryTextBox;        // 年薪輸入框
        private System.Windows.Forms.TextBox yearsTextBox;         // 年資輸入框
        private System.Windows.Forms.Label outputDescriptionLabel;  // 貸款審核結果說明標籤
        private System.Windows.Forms.Label decisionLabel;           // 審核結果顯示標籤
        private System.Windows.Forms.Button checkButton;            // 檢查資格按鈕
        private System.Windows.Forms.Button clearButton;            // 清除按鈕
        private System.Windows.Forms.Button exitButton;             // 離開按鈕
    }
}

