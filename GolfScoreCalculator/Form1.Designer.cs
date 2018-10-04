namespace GolfScoreCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.golferGroupBox1 = new System.Windows.Forms.GroupBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.holeLabel1 = new System.Windows.Forms.Label();
            this.holeNumberLabel1 = new System.Windows.Forms.Label();
            this.holeNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.scoresListBox1 = new System.Windows.Forms.ListBox();
            this.totalScoreLabel1 = new System.Windows.Forms.Label();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.golferGroupBox2 = new System.Windows.Forms.GroupBox();
            this.totalLabel2 = new System.Windows.Forms.Label();
            this.totalScoreLabel2 = new System.Windows.Forms.Label();
            this.scoreListBox2 = new System.Windows.Forms.ListBox();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.holeNumberTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.holeLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.winnerButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.golferGroupBox1.SuspendLayout();
            this.golferGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(190, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Golf Score Calculator";
            // 
            // golferGroupBox1
            // 
            this.golferGroupBox1.Controls.Add(this.totalLabel1);
            this.golferGroupBox1.Controls.Add(this.totalScoreLabel1);
            this.golferGroupBox1.Controls.Add(this.scoresListBox1);
            this.golferGroupBox1.Controls.Add(this.nextButton1);
            this.golferGroupBox1.Controls.Add(this.holeNumberTextBox1);
            this.golferGroupBox1.Controls.Add(this.holeNumberLabel1);
            this.golferGroupBox1.Controls.Add(this.holeLabel1);
            this.golferGroupBox1.Controls.Add(this.nameTextBox1);
            this.golferGroupBox1.Controls.Add(this.nameLabel1);
            this.golferGroupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.golferGroupBox1.ForeColor = System.Drawing.Color.White;
            this.golferGroupBox1.Location = new System.Drawing.Point(35, 100);
            this.golferGroupBox1.Name = "golferGroupBox1";
            this.golferGroupBox1.Size = new System.Drawing.Size(262, 450);
            this.golferGroupBox1.TabIndex = 1;
            this.golferGroupBox1.TabStop = false;
            this.golferGroupBox1.Text = " Golfer 1 ";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(15, 39);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(62, 21);
            this.nameLabel1.TabIndex = 0;
            this.nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(19, 64);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(223, 28);
            this.nameTextBox1.TabIndex = 1;
            // 
            // holeLabel1
            // 
            this.holeLabel1.AutoSize = true;
            this.holeLabel1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.holeLabel1.Location = new System.Drawing.Point(14, 114);
            this.holeLabel1.Name = "holeLabel1";
            this.holeLabel1.Size = new System.Drawing.Size(57, 25);
            this.holeLabel1.TabIndex = 2;
            this.holeLabel1.Text = "Hole";
            // 
            // holeNumberLabel1
            // 
            this.holeNumberLabel1.AutoSize = true;
            this.holeNumberLabel1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.holeNumberLabel1.Location = new System.Drawing.Point(68, 115);
            this.holeNumberLabel1.Name = "holeNumberLabel1";
            this.holeNumberLabel1.Size = new System.Drawing.Size(36, 25);
            this.holeNumberLabel1.TabIndex = 3;
            this.holeNumberLabel1.Text = "#1";
            // 
            // holeNumberTextBox1
            // 
            this.holeNumberTextBox1.Location = new System.Drawing.Point(110, 114);
            this.holeNumberTextBox1.Name = "holeNumberTextBox1";
            this.holeNumberTextBox1.Size = new System.Drawing.Size(42, 28);
            this.holeNumberTextBox1.TabIndex = 4;
            // 
            // nextButton1
            // 
            this.nextButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nextButton1.ForeColor = System.Drawing.Color.Black;
            this.nextButton1.Location = new System.Drawing.Point(170, 114);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(72, 28);
            this.nextButton1.TabIndex = 5;
            this.nextButton1.Text = "Next";
            this.nextButton1.UseVisualStyleBackColor = true;
            // 
            // scoresListBox1
            // 
            this.scoresListBox1.Enabled = false;
            this.scoresListBox1.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scoresListBox1.FormattingEnabled = true;
            this.scoresListBox1.ItemHeight = 22;
            this.scoresListBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"});
            this.scoresListBox1.Location = new System.Drawing.Point(19, 172);
            this.scoresListBox1.Name = "scoresListBox1";
            this.scoresListBox1.Size = new System.Drawing.Size(223, 202);
            this.scoresListBox1.TabIndex = 6;
            // 
            // totalScoreLabel1
            // 
            this.totalScoreLabel1.AutoSize = true;
            this.totalScoreLabel1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalScoreLabel1.Location = new System.Drawing.Point(14, 404);
            this.totalScoreLabel1.Name = "totalScoreLabel1";
            this.totalScoreLabel1.Size = new System.Drawing.Size(129, 25);
            this.totalScoreLabel1.TabIndex = 7;
            this.totalScoreLabel1.Text = "Total Score:";
            // 
            // totalLabel1
            // 
            this.totalLabel1.AutoSize = true;
            this.totalLabel1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalLabel1.Location = new System.Drawing.Point(206, 404);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(36, 25);
            this.totalLabel1.TabIndex = 8;
            this.totalLabel1.Text = "35";
            // 
            // golferGroupBox2
            // 
            this.golferGroupBox2.Controls.Add(this.totalLabel2);
            this.golferGroupBox2.Controls.Add(this.totalScoreLabel2);
            this.golferGroupBox2.Controls.Add(this.scoreListBox2);
            this.golferGroupBox2.Controls.Add(this.nextButton2);
            this.golferGroupBox2.Controls.Add(this.holeNumberTextBox2);
            this.golferGroupBox2.Controls.Add(this.label3);
            this.golferGroupBox2.Controls.Add(this.holeLabel2);
            this.golferGroupBox2.Controls.Add(this.nameTextBox2);
            this.golferGroupBox2.Controls.Add(this.nameLabel2);
            this.golferGroupBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.golferGroupBox2.ForeColor = System.Drawing.Color.White;
            this.golferGroupBox2.Location = new System.Drawing.Point(333, 100);
            this.golferGroupBox2.Name = "golferGroupBox2";
            this.golferGroupBox2.Size = new System.Drawing.Size(262, 450);
            this.golferGroupBox2.TabIndex = 2;
            this.golferGroupBox2.TabStop = false;
            this.golferGroupBox2.Text = " Golfer 2 ";
            // 
            // totalLabel2
            // 
            this.totalLabel2.AutoSize = true;
            this.totalLabel2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalLabel2.Location = new System.Drawing.Point(206, 404);
            this.totalLabel2.Name = "totalLabel2";
            this.totalLabel2.Size = new System.Drawing.Size(36, 25);
            this.totalLabel2.TabIndex = 8;
            this.totalLabel2.Text = "35";
            // 
            // totalScoreLabel2
            // 
            this.totalScoreLabel2.AutoSize = true;
            this.totalScoreLabel2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalScoreLabel2.Location = new System.Drawing.Point(14, 404);
            this.totalScoreLabel2.Name = "totalScoreLabel2";
            this.totalScoreLabel2.Size = new System.Drawing.Size(129, 25);
            this.totalScoreLabel2.TabIndex = 7;
            this.totalScoreLabel2.Text = "Total Score:";
            // 
            // scoreListBox2
            // 
            this.scoreListBox2.Enabled = false;
            this.scoreListBox2.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scoreListBox2.FormattingEnabled = true;
            this.scoreListBox2.ItemHeight = 22;
            this.scoreListBox2.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"});
            this.scoreListBox2.Location = new System.Drawing.Point(19, 172);
            this.scoreListBox2.Name = "scoreListBox2";
            this.scoreListBox2.Size = new System.Drawing.Size(223, 202);
            this.scoreListBox2.TabIndex = 6;
            // 
            // nextButton2
            // 
            this.nextButton2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nextButton2.ForeColor = System.Drawing.Color.Black;
            this.nextButton2.Location = new System.Drawing.Point(170, 114);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(72, 28);
            this.nextButton2.TabIndex = 5;
            this.nextButton2.Text = "Next";
            this.nextButton2.UseVisualStyleBackColor = true;
            // 
            // holeNumberTextBox2
            // 
            this.holeNumberTextBox2.Location = new System.Drawing.Point(110, 114);
            this.holeNumberTextBox2.Name = "holeNumberTextBox2";
            this.holeNumberTextBox2.Size = new System.Drawing.Size(42, 28);
            this.holeNumberTextBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "#1";
            // 
            // holeLabel2
            // 
            this.holeLabel2.AutoSize = true;
            this.holeLabel2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.holeLabel2.Location = new System.Drawing.Point(14, 114);
            this.holeLabel2.Name = "holeLabel2";
            this.holeLabel2.Size = new System.Drawing.Size(57, 25);
            this.holeLabel2.TabIndex = 2;
            this.holeLabel2.Text = "Hole";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(19, 64);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(223, 28);
            this.nameTextBox2.TabIndex = 1;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(15, 39);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(62, 21);
            this.nameLabel2.TabIndex = 0;
            this.nameLabel2.Text = "Name:";
            // 
            // winnerButton
            // 
            this.winnerButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.winnerButton.ForeColor = System.Drawing.Color.Black;
            this.winnerButton.Location = new System.Drawing.Point(35, 602);
            this.winnerButton.Name = "winnerButton";
            this.winnerButton.Size = new System.Drawing.Size(180, 40);
            this.winnerButton.TabIndex = 3;
            this.winnerButton.Text = "Determine Winner";
            this.winnerButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quitButton.ForeColor = System.Drawing.Color.Black;
            this.quitButton.Location = new System.Drawing.Point(503, 602);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(72, 40);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(266, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lynn wins!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(635, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.winnerButton);
            this.Controls.Add(this.golferGroupBox2);
            this.Controls.Add(this.golferGroupBox1);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Golf Score Calculator";
            this.golferGroupBox1.ResumeLayout(false);
            this.golferGroupBox1.PerformLayout();
            this.golferGroupBox2.ResumeLayout(false);
            this.golferGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox golferGroupBox1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label totalScoreLabel1;
        private System.Windows.Forms.ListBox scoresListBox1;
        private System.Windows.Forms.Button nextButton1;
        private System.Windows.Forms.TextBox holeNumberTextBox1;
        private System.Windows.Forms.Label holeNumberLabel1;
        private System.Windows.Forms.Label holeLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.GroupBox golferGroupBox2;
        private System.Windows.Forms.Label totalLabel2;
        private System.Windows.Forms.Label totalScoreLabel2;
        private System.Windows.Forms.ListBox scoreListBox2;
        private System.Windows.Forms.Button nextButton2;
        private System.Windows.Forms.TextBox holeNumberTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label holeLabel2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Button winnerButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
    }
}

