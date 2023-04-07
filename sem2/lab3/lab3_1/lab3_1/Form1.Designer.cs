namespace lab3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Player1Label = new Label();
            Player2Label = new Label();
            Player1ScoreLabel = new Label();
            Player2ScoreLabel = new Label();
            ResetScoreButton = new Button();
            NewGameButton = new Button();
            SuspendLayout();
            // 
            // Player1Label
            // 
            Player1Label.AutoSize = true;
            Player1Label.Location = new Point(101, 46);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(50, 15);
            Player1Label.TabIndex = 0;
            Player1Label.Text = "Игрок 1";
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Location = new Point(478, 46);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(50, 15);
            Player2Label.TabIndex = 1;
            Player2Label.Text = "Игрок 2";
            // 
            // Player1ScoreLabel
            // 
            Player1ScoreLabel.AutoSize = true;
            Player1ScoreLabel.Location = new Point(116, 76);
            Player1ScoreLabel.Name = "Player1ScoreLabel";
            Player1ScoreLabel.Size = new Size(13, 15);
            Player1ScoreLabel.TabIndex = 2;
            Player1ScoreLabel.Text = "0";
            // 
            // Player2ScoreLabel
            // 
            Player2ScoreLabel.AutoSize = true;
            Player2ScoreLabel.Location = new Point(496, 76);
            Player2ScoreLabel.Name = "Player2ScoreLabel";
            Player2ScoreLabel.Size = new Size(13, 15);
            Player2ScoreLabel.TabIndex = 3;
            Player2ScoreLabel.Text = "0";
            // 
            // ResetScoreButton
            // 
            ResetScoreButton.Location = new Point(70, 496);
            ResetScoreButton.Name = "ResetScoreButton";
            ResetScoreButton.Size = new Size(118, 23);
            ResetScoreButton.TabIndex = 4;
            ResetScoreButton.Text = "Сбросить счет";
            ResetScoreButton.UseVisualStyleBackColor = true;
            ResetScoreButton.Click += ResetScoreButton_Click;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(460, 496);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(95, 23);
            NewGameButton.TabIndex = 5;
            NewGameButton.Text = "Новая игра";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 561);
            Controls.Add(NewGameButton);
            Controls.Add(ResetScoreButton);
            Controls.Add(Player2ScoreLabel);
            Controls.Add(Player1ScoreLabel);
            Controls.Add(Player2Label);
            Controls.Add(Player1Label);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Player1Label;
        private Label Player2Label;
        private Label Player1ScoreLabel;
        private Label Player2ScoreLabel;
        private Button ResetScoreButton;
        private Button NewGameButton;
    }
}