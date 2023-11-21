namespace FlappyGame
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            birdPictureBox = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            bottomPipe = new PictureBox();
            topPipe = new PictureBox();
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)birdPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomPipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topPipe).BeginInit();
            SuspendLayout();
            // 
            // birdPictureBox
            // 
            birdPictureBox.Location = new Point(54, 178);
            birdPictureBox.Name = "birdPictureBox";
            birdPictureBox.Size = new Size(56, 56);
            birdPictureBox.TabIndex = 0;
            birdPictureBox.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // bottomPipe
            // 
            bottomPipe.Location = new Point(438, 239);
            bottomPipe.Name = "bottomPipe";
            bottomPipe.Size = new Size(80, 216);
            bottomPipe.TabIndex = 1;
            bottomPipe.TabStop = false;
            // 
            // topPipe
            // 
            topPipe.Location = new Point(646, -1);
            topPipe.Name = "topPipe";
            topPipe.Size = new Size(80, 216);
            topPipe.TabIndex = 2;
            topPipe.TabStop = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(126, 32);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "scoreLabel";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(topPipe);
            Controls.Add(bottomPipe);
            Controls.Add(birdPictureBox);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)birdPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomPipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox birdPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox bottomPipe;
        private PictureBox topPipe;
        private Label scoreLabel;
    }
}