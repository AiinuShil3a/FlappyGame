namespace FlappyGame
{
    partial class GameOverForm
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
            scoreLabel = new Label();
            highscoreLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BorderStyle = BorderStyle.Fixed3D;
            scoreLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(145, 39);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "scoreLabel";
            // 
            // highscoreLabel
            // 
            highscoreLabel.AutoSize = true;
            highscoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            highscoreLabel.Location = new Point(12, 56);
            highscoreLabel.Name = "highscoreLabel";
            highscoreLabel.Size = new Size(0, 21);
            highscoreLabel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(291, 125);
            button1.Name = "button1";
            button1.Size = new Size(189, 62);
            button1.TabIndex = 2;
            button1.Text = "Play again!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(291, 213);
            button2.Name = "button2";
            button2.Size = new Size(189, 62);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(highscoreLabel);
            Controls.Add(scoreLabel);
            Name = "GameOverForm";
            Text = "GameOverForm";
            Load += GameOverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private Label highscoreLabel;
        private Button button1;
        private Button button2;
    }
}