namespace Tutrorial_3_1
{
    partial class BirthDateString
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
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.dayOfMonthLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekLabel.Location = new System.Drawing.Point(64, 41);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(116, 48);
            this.dayOfWeekLabel.TabIndex = 0;
            this.dayOfWeekLabel.Text = "星期";
            // 
            // dayOfMonthLabel
            // 
            this.dayOfMonthLabel.AutoSize = true;
            this.dayOfMonthLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthLabel.Location = new System.Drawing.Point(112, 206);
            this.dayOfMonthLabel.Name = "dayOfMonthLabel";
            this.dayOfMonthLabel.Size = new System.Drawing.Size(68, 48);
            this.dayOfMonthLabel.TabIndex = 1;
            this.dayOfMonthLabel.Text = "日";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthLabel.Location = new System.Drawing.Point(112, 126);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(68, 48);
            this.MonthLabel.TabIndex = 2;
            this.MonthLabel.Text = "月";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearLabel.Location = new System.Drawing.Point(112, 290);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(68, 48);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "年";
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(186, 38);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(365, 65);
            this.dayOfWeekTextBox.TabIndex = 4;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthTextBox.Location = new System.Drawing.Point(186, 123);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(365, 65);
            this.MonthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(186, 203);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(365, 65);
            this.dayOfMonthTextBox.TabIndex = 6;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearTextBox.Location = new System.Drawing.Point(186, 287);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(365, 65);
            this.YearTextBox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutputLabel.Location = new System.Drawing.Point(19, 386);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(642, 60);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            this.showDateButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showDateButton.Location = new System.Drawing.Point(34, 483);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(227, 55);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(276, 483);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 55);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(466, 483);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 55);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // BirthDateString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 558);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.dayOfMonthLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Name = "BirthDateString";
            this.Text = "生日日期字串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label dayOfMonthLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

