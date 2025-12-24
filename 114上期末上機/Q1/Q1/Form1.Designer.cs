namespace Q1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;

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
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.stoneButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBoxstone = new System.Windows.Forms.PictureBox();
            this.computerPictureBoxpaper = new System.Windows.Forms.PictureBox();
            this.computerPictureBoxstone = new System.Windows.Forms.PictureBox();
            this.playerPictureBoxscissor = new System.Windows.Forms.PictureBox();
            this.computerPictureBoxscissor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBoxstone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxstone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBoxscissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxscissor)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Location = new System.Drawing.Point(120, 40);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(128, 46);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(560, 40);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(128, 46);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "玩家出";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(180, 240);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(500, 53);
            this.resultLabel.TabIndex = 0;
            // 
            // stoneButton
            // 
            this.stoneButton.Location = new System.Drawing.Point(120, 310);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(160, 60);
            this.stoneButton.TabIndex = 1;
            this.stoneButton.Text = "石頭";
            this.stoneButton.UseVisualStyleBackColor = true;
            this.stoneButton.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(350, 310);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(160, 60);
            this.paperButton.TabIndex = 2;
            this.paperButton.Text = "布";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Location = new System.Drawing.Point(580, 310);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(160, 60);
            this.scissorButton.TabIndex = 3;
            this.scissorButton.Text = "剪刀";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(300, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 60);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "結束遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::Q1.Properties.Resources.paper_player;
            this.playerPictureBox.Location = new System.Drawing.Point(523, 89);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(240, 120);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 10;
            this.playerPictureBox.TabStop = false;
            // 
            // playerPictureBoxstone
            // 
            this.playerPictureBoxstone.Image = global::Q1.Properties.Resources.stone_player;
            this.playerPictureBoxstone.Location = new System.Drawing.Point(523, 90);
            this.playerPictureBoxstone.Name = "playerPictureBoxstone";
            this.playerPictureBoxstone.Size = new System.Drawing.Size(240, 120);
            this.playerPictureBoxstone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBoxstone.TabIndex = 9;
            this.playerPictureBoxstone.TabStop = false;
            // 
            // computerPictureBoxpaper
            // 
            this.computerPictureBoxpaper.Image = global::Q1.Properties.Resources.paper_computer;
            this.computerPictureBoxpaper.Location = new System.Drawing.Point(78, 89);
            this.computerPictureBoxpaper.Name = "computerPictureBoxpaper";
            this.computerPictureBoxpaper.Size = new System.Drawing.Size(240, 120);
            this.computerPictureBoxpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBoxpaper.TabIndex = 8;
            this.computerPictureBoxpaper.TabStop = false;
            // 
            // computerPictureBoxstone
            // 
            this.computerPictureBoxstone.Image = global::Q1.Properties.Resources.stone_computer;
            this.computerPictureBoxstone.Location = new System.Drawing.Point(78, 89);
            this.computerPictureBoxstone.Name = "computerPictureBoxstone";
            this.computerPictureBoxstone.Size = new System.Drawing.Size(240, 120);
            this.computerPictureBoxstone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBoxstone.TabIndex = 7;
            this.computerPictureBoxstone.TabStop = false;
            // 
            // playerPictureBoxscissor
            // 
            this.playerPictureBoxscissor.Image = global::Q1.Properties.Resources.scissor_player;
            this.playerPictureBoxscissor.Location = new System.Drawing.Point(523, 90);
            this.playerPictureBoxscissor.Name = "playerPictureBoxscissor";
            this.playerPictureBoxscissor.Size = new System.Drawing.Size(240, 120);
            this.playerPictureBoxscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBoxscissor.TabIndex = 6;
            this.playerPictureBoxscissor.TabStop = false;
            // 
            // computerPictureBoxscissor
            // 
            this.computerPictureBoxscissor.Image = global::Q1.Properties.Resources.scissor_computer;
            this.computerPictureBoxscissor.Location = new System.Drawing.Point(78, 90);
            this.computerPictureBoxscissor.Name = "computerPictureBoxscissor";
            this.computerPictureBoxscissor.Size = new System.Drawing.Size(240, 120);
            this.computerPictureBoxscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBoxscissor.TabIndex = 5;
            this.computerPictureBoxscissor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.playerPictureBoxstone);
            this.Controls.Add(this.computerPictureBoxpaper);
            this.Controls.Add(this.computerPictureBoxstone);
            this.Controls.Add(this.playerPictureBoxscissor);
            this.Controls.Add(this.computerPictureBoxscissor);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.Name = "Form1";
            this.Text = "猜拳遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBoxstone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxstone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBoxscissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxscissor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox computerPictureBoxscissor;
        private System.Windows.Forms.PictureBox playerPictureBoxscissor;
        private System.Windows.Forms.PictureBox computerPictureBoxstone;
        private System.Windows.Forms.PictureBox computerPictureBoxpaper;
        private System.Windows.Forms.PictureBox playerPictureBoxstone;
        private System.Windows.Forms.PictureBox playerPictureBox;
    }
}

