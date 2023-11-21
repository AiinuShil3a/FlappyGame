using FlappyXmySQL;
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
    public partial class GameOverForm : Form
    {
        private int score;
        private Player _player;
        private ConDB db = new ConDB();

        public GameOverForm(Player player, int score)
        {
            _player = player;
            this.score = score;
            InitializeComponent();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            //ไม่อนุญาติให้ขยายจอ
            this.MaximizeBox = false;

            string imagePath = Path.Combine(Application.StartupPath, "Images", "BGMarrio.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile(imagePath);
            scoreLabel.Text = "Your score: " + score;
            if (score > int.Parse(_player.HighScore))
            {
                _player.HighScore = score.ToString();
                db.UpdatePlayer(_player.ID, _player.Name, _player.User, _player.Password, _player.Images , _player.HighScore);
                highscoreLabel.Text = "New High Score!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            GameForm game = new GameForm(_player);
            this.Hide();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home nextForm = new Home(_player);
            nextForm.Show();
            this.Hide();
        }
    }
}
