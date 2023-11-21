using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlappyXmySQL;
using static FlappyXmySQL.ConDB;
using System.Reflection.Emit;

namespace FlappyGame
{
    public partial class Home : Form
    {
        private Player _player;

        public Home(Player player)
        {
            InitializeComponent();
            _player = player;

            // ตอนนี้คุณสามารถเรียกใช้ข้อมูลของ _player ได้ทั้งหมดเช่น _player.Name, _player.Img, etc.
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //ไม่อนุญาติให้ขยายจอ
            this.MaximizeBox = false;

            label2.Text = _player.Name;
            string imagePath = Path.Combine(Application.StartupPath, "Images", "BGMarrio.jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            //ขยายรูป
            this.BackgroundImageLayout = ImageLayout.Stretch;
            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "Ogre.png");
            Image image = Image.FromFile(imagePath2);
            pictureBox2.Image = image;
            //ขยายรูป
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //ลบ BG
            pictureBox2.BackColor = Color.Transparent;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(_player);
            this.Hide();
            game.Show();
        }

        private void Option_Click(object sender, EventArgs e)
        {
            Update goUpdate = new Update(_player);
            this.Hide();
            goUpdate.Show();
        }
    }
}
