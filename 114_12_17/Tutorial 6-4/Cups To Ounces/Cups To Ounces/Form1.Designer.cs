namespace Cups_To_Ounces
{
    partial class Form1
    {
        /// <summary>
        /// 需要的設計工具變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有使用中的資源
        /// </summary>
        /// <param name="disposing">如果託管資源應被直接儲存則為 true；否則為 false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 此方法的內容
        /// </summary>
        private void InitializeComponent()
        {
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(122, 35);
            this.bannerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(387, 40);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "杯子轉流體盎司轉換器";
            // 
            // cupsPromptLabel
            // 
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsPromptLabel.Location = new System.Drawing.Point(107, 164);
            this.cupsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(125, 40);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "杯子：";
            // 
            // cupsTextBox
            // 
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsTextBox.Location = new System.Drawing.Point(317, 161);
            this.cupsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(223, 48);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ouncesLabel.Location = new System.Drawing.Point(317, 246);
            this.ouncesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(224, 55);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(107, 254);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(197, 40);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "流體盎司：";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.convertButton.Location = new System.Drawing.Point(137, 371);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(165, 62);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(317, 371);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 62);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 504);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "杯子轉流體盎司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 標籤控制項 - 用於顯示標題
        private System.Windows.Forms.Label bannerLabel;
        // 標籤控制項 - 用於提示使用者輸入杯子數量
        private System.Windows.Forms.Label cupsPromptLabel;
        // 文字框控制項 - 讓使用者輸入杯子數量
        private System.Windows.Forms.TextBox cupsTextBox;
        // 標籤控制項 - 用於顯示轉換後的流體盎司結果
        private System.Windows.Forms.Label ouncesLabel;
        // 標籤控制項 - 用於說明輸出結果的含義
        private System.Windows.Forms.Label outputDescriptionLabel;
        // 按鈕控制項 - 執行轉換計算
        private System.Windows.Forms.Button convertButton;
        // 按鈕控制項 - 關閉應用程式
        private System.Windows.Forms.Button exitButton;
    }
}

