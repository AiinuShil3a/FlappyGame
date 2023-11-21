using FlappyXmySQL;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.IO;
using System.Drawing;
using static FlappyXmySQL.ConDB;

namespace FlappyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataToGrid()
        {
            ConDB db = new ConDB();
            DataTable dt = db.GetAllPlayersHighScore();
            dataGridView1.DataSource = dt;

            // ซ่อนคอลัมน์
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["User"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Images"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //ไม่อนุญาติให้ขยายจอ
                this.MaximizeBox = false;

                string imagePath = Path.Combine(Application.StartupPath, "Images", "Miky.png");
                Image img = Image.FromFile(imagePath);

                LoadDataToGrid();
                pictureBox6.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            // ไปหน้าถัดไป
            SignUp nextForm = new SignUp();
            nextForm.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            if (user == "" || password == "")
            {
                MessageBox.Show("คุณลืมกรอกอะไรหรือป่าว!");
            }
            else
            {
                ConDB db = new ConDB();

                // ตรวจสอบว่ามี User ในระบบหรือไม่
                if (!db.IsUserExist(user))
                {
                    MessageBox.Show("ไม่พบผู้ใช้นี้ในระบบ!");
                    return;
                }

                // ตรวจสอบว่ารหัสผ่านตรงกันหรือไม่
                if (!db.IsValidUser(user, password))
                {
                    MessageBox.Show("Username หรือ Password ไม่ถูกต้อง!");
                    return;
                }

                // พาไปยัง Home และส่งข้อมูลของผู้ใช้ไปด้วย
                Player playerData = db.GetPlayerData(user);

                Home nextForm = new Home(playerData);
                nextForm.Show();
                this.Hide();
            }
        }
    }
}