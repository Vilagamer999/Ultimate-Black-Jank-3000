namespace CardGameGUI
{
    partial class FormBlackJack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlackJack));
            this.NewGameButton = new System.Windows.Forms.Button();
            this.Player1DealButton = new System.Windows.Forms.Button();
            this.P1CurrentScoreLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P1ScoreLabel = new System.Windows.Forms.Label();
            this.P2ScoreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.P2CurrentScoreLabel = new System.Windows.Forms.Label();
            this.Player2DealButton = new System.Windows.Forms.Button();
            this.Player2Skip = new System.Windows.Forms.Button();
            this.Player1Skip = new System.Windows.Forms.Button();
            this.PlayerWinText = new System.Windows.Forms.Label();
            this.PauseMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.White;
            this.NewGameButton.Location = new System.Drawing.Point(34, 11);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 42);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Player1DealButton
            // 
            this.Player1DealButton.BackColor = System.Drawing.SystemColors.Control;
            this.Player1DealButton.Location = new System.Drawing.Point(64, 224);
            this.Player1DealButton.Name = "Player1DealButton";
            this.Player1DealButton.Size = new System.Drawing.Size(148, 46);
            this.Player1DealButton.TabIndex = 2;
            this.Player1DealButton.Text = "Player 1 Deal";
            this.Player1DealButton.UseVisualStyleBackColor = false;
            this.Player1DealButton.Click += new System.EventHandler(this.Player1DealButton_Click);
            // 
            // P1CurrentScoreLabel
            // 
            this.P1CurrentScoreLabel.AutoSize = true;
            this.P1CurrentScoreLabel.BackColor = System.Drawing.Color.White;
            this.P1CurrentScoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1CurrentScoreLabel.Location = new System.Drawing.Point(30, 148);
            this.P1CurrentScoreLabel.Name = "P1CurrentScoreLabel";
            this.P1CurrentScoreLabel.Size = new System.Drawing.Size(19, 21);
            this.P1CurrentScoreLabel.TabIndex = 3;
            this.P1CurrentScoreLabel.Text = "0";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "P1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "P2";
            // 
            // P1ScoreLabel
            // 
            this.P1ScoreLabel.AutoSize = true;
            this.P1ScoreLabel.BackColor = System.Drawing.Color.White;
            this.P1ScoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1ScoreLabel.Location = new System.Drawing.Point(367, 66);
            this.P1ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1ScoreLabel.Name = "P1ScoreLabel";
            this.P1ScoreLabel.Size = new System.Drawing.Size(19, 21);
            this.P1ScoreLabel.TabIndex = 7;
            this.P1ScoreLabel.Text = "0";
            // 
            // P2ScoreLabel
            // 
            this.P2ScoreLabel.AutoSize = true;
            this.P2ScoreLabel.BackColor = System.Drawing.Color.White;
            this.P2ScoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2ScoreLabel.Location = new System.Drawing.Point(443, 66);
            this.P2ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P2ScoreLabel.Name = "P2ScoreLabel";
            this.P2ScoreLabel.Size = new System.Drawing.Size(19, 21);
            this.P2ScoreLabel.TabIndex = 8;
            this.P2ScoreLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 1";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Player 2";
            // 
            // P2CurrentScoreLabel
            // 
            this.P2CurrentScoreLabel.AutoSize = true;
            this.P2CurrentScoreLabel.BackColor = System.Drawing.Color.White;
            this.P2CurrentScoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2CurrentScoreLabel.Location = new System.Drawing.Point(231, 148);
            this.P2CurrentScoreLabel.Name = "P2CurrentScoreLabel";
            this.P2CurrentScoreLabel.Size = new System.Drawing.Size(19, 21);
            this.P2CurrentScoreLabel.TabIndex = 11;
            this.P2CurrentScoreLabel.Text = "0";
            // 
            // Player2DealButton
            // 
            this.Player2DealButton.BackColor = System.Drawing.SystemColors.Control;
            this.Player2DealButton.Location = new System.Drawing.Point(265, 224);
            this.Player2DealButton.Name = "Player2DealButton";
            this.Player2DealButton.Size = new System.Drawing.Size(148, 46);
            this.Player2DealButton.TabIndex = 10;
            this.Player2DealButton.Text = "Player 2 Deal";
            this.Player2DealButton.UseVisualStyleBackColor = false;
            this.Player2DealButton.Click += new System.EventHandler(this.Player2DealButton_Click);
            // 
            // Player2Skip
            // 
            this.Player2Skip.BackColor = System.Drawing.SystemColors.Control;
            this.Player2Skip.Location = new System.Drawing.Point(265, 276);
            this.Player2Skip.Name = "Player2Skip";
            this.Player2Skip.Size = new System.Drawing.Size(148, 46);
            this.Player2Skip.TabIndex = 14;
            this.Player2Skip.Text = "Skip Turn";
            this.Player2Skip.UseVisualStyleBackColor = false;
            this.Player2Skip.Click += new System.EventHandler(this.Player2Skip_Click);
            // 
            // Player1Skip
            // 
            this.Player1Skip.BackColor = System.Drawing.SystemColors.Control;
            this.Player1Skip.Location = new System.Drawing.Point(64, 276);
            this.Player1Skip.Name = "Player1Skip";
            this.Player1Skip.Size = new System.Drawing.Size(148, 46);
            this.Player1Skip.TabIndex = 13;
            this.Player1Skip.Text = "Skip Turn";
            this.Player1Skip.UseVisualStyleBackColor = false;
            this.Player1Skip.Click += new System.EventHandler(this.Player1Skip_Click);
            // 
            // PlayerWinText
            // 
            this.PlayerWinText.AutoSize = true;
            this.PlayerWinText.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerWinText.Font = new System.Drawing.Font("Marlett", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinText.ForeColor = System.Drawing.Color.Black;
            this.PlayerWinText.Location = new System.Drawing.Point(68, 244);
            this.PlayerWinText.Name = "PlayerWinText";
            this.PlayerWinText.Size = new System.Drawing.Size(338, 55);
            this.PlayerWinText.TabIndex = 15;
            this.PlayerWinText.Text = "Player 0 wins!";
            // 
            // PauseMusic
            // 
            this.PauseMusic.BackColor = System.Drawing.SystemColors.Control;
            this.PauseMusic.Location = new System.Drawing.Point(12, 360);
            this.PauseMusic.Name = "PauseMusic";
            this.PauseMusic.Size = new System.Drawing.Size(76, 27);
            this.PauseMusic.TabIndex = 16;
            this.PauseMusic.Text = "Pause Music";
            this.PauseMusic.UseVisualStyleBackColor = false;
            this.PauseMusic.Click += new System.EventHandler(this.PauseMusic_Click);
            // 
            // FormBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 399);
            this.Controls.Add(this.PauseMusic);
            this.Controls.Add(this.PlayerWinText);
            this.Controls.Add(this.Player2Skip);
            this.Controls.Add(this.Player1Skip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P2CurrentScoreLabel);
            this.Controls.Add(this.Player2DealButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.P2ScoreLabel);
            this.Controls.Add(this.P1ScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P1CurrentScoreLabel);
            this.Controls.Add(this.Player1DealButton);
            this.Controls.Add(this.NewGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBlackJack";
            this.Text = "Ultimate Black Jank 3000";
            this.Load += new System.EventHandler(this.FormBlackJack_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBlackJack_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button Player1DealButton;
        private System.Windows.Forms.Label P1CurrentScoreLabel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label P1ScoreLabel;
        private System.Windows.Forms.Label P2ScoreLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label P2CurrentScoreLabel;
        private System.Windows.Forms.Button Player2DealButton;
        private System.Windows.Forms.Button Player2Skip;
        private System.Windows.Forms.Button Player1Skip;
        private System.Windows.Forms.Label PlayerWinText;
        private System.Windows.Forms.Button PauseMusic;
    }
}

