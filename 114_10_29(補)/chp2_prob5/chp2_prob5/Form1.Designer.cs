namespace chp2_prob5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.TailspictureBox = new System.Windows.Forms.PictureBox();
            this.HeadpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TailspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(111, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "人頭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(314, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "數字";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitbutton.Location = new System.Drawing.Point(517, 316);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(148, 82);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "離開";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // TailspictureBox
            // 
            this.TailspictureBox.Image = global::chp2_prob5.Properties.Resources.Tails2;
            this.TailspictureBox.Location = new System.Drawing.Point(413, 38);
            this.TailspictureBox.Name = "TailspictureBox";
            this.TailspictureBox.Size = new System.Drawing.Size(312, 257);
            this.TailspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TailspictureBox.TabIndex = 4;
            this.TailspictureBox.TabStop = false;
            this.TailspictureBox.Visible = false;
            // 
            // HeadpictureBox
            // 
            this.HeadpictureBox.Image = global::chp2_prob5.Properties.Resources.Heads2;
            this.HeadpictureBox.Location = new System.Drawing.Point(53, 38);
            this.HeadpictureBox.Name = "HeadpictureBox";
            this.HeadpictureBox.Size = new System.Drawing.Size(312, 257);
            this.HeadpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadpictureBox.TabIndex = 3;
            this.HeadpictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TailspictureBox);
            this.Controls.Add(this.HeadpictureBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "硬幣翻轉";
            ((System.ComponentModel.ISupportInitialize)(this.TailspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.PictureBox HeadpictureBox;
        private System.Windows.Forms.PictureBox TailspictureBox;
    }
}

