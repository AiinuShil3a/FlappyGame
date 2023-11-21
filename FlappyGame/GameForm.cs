using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlappyXmySQL.ConDB;

namespace FlappyGame
{
    public partial class GameForm : Form
    {
        int gravity = 5;
        int jumping = 0;
        int pipeSpeed = 5;
        int score = 0;
        bool isJumping = false;

        private Player _player;
        public GameForm(Player player)
        {
            _player = player;
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //ไม่อนุญาติให้ขยายจอ
            this.MaximizeBox = false;

            string imagePath = Path.Combine(Application.StartupPath, "Images", "BGMarrio.jpg");
            string imagePath2 = Path.Combine(Application.StartupPath, "Images", _player.Images);
            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "Ogre.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Image image = Image.FromFile(imagePath2);
            Image image2 = Image.FromFile(imagePath3);
            Image imageForTopPipe = Image.FromFile(imagePath3);
            birdPictureBox.Image = image;
            topPipe.Image = imageForTopPipe;
            bottomPipe.Image = image2;
            //ขยายรูป
            this.BackgroundImage = Image.FromFile(imagePath);
            birdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            topPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            bottomPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            //Flip
            imageForTopPipe.RotateFlip(RotateFlipType.RotateNoneFlipY);
            //ลบพื้นหลัง
            topPipe.BackColor = Color.Transparent;
            bottomPipe.BackColor = Color.Transparent;
            //GameStart
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            birdPictureBox.Top += gravity;

            if (isJumping)
            {
                jumping--;

                if (jumping <= 0)
                {
                    isJumping = false;
                }
            }

            topPipe.Left -= pipeSpeed;
            bottomPipe.Left -= pipeSpeed;
            scoreLabel.Text = $"Score: {score}";

            if (topPipe.Left < -topPipe.Width)
            {
                topPipe.Left = this.ClientSize.Width;
                topPipe.Height = new Random().Next(50, this.ClientSize.Height - 150);

                bottomPipe.Left = topPipe.Left;
                bottomPipe.Top = topPipe.Bottom + 100;
            }


            if (birdPictureBox.Left > topPipe.Right && topPipe.Right + pipeSpeed >= birdPictureBox.Left)
            {
                score++;
            }


            if (birdPictureBox.Bounds.IntersectsWith(topPipe.Bounds) ||
                birdPictureBox.Bounds.IntersectsWith(bottomPipe.Bounds) ||
                birdPictureBox.Top < 0 || birdPictureBox.Bottom > this.ClientSize.Height)
            {
                EndGame();
            }
        }


        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                gravity = -5;
                jumping = 10;
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isJumping = false;
                gravity = 5;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            this.Hide();

            GameOverForm gameOver = new GameOverForm(_player, score);
            gameOver.ShowDialog();

            this.Close();
        }
    }
}
