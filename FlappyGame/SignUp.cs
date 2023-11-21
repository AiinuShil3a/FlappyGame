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
using System.IO;
using System.Xml.Linq;
using static FlappyXmySQL.ConDB;

namespace FlappyGame
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //ไม่อนุญาติให้ขยายจอ
            this.MaximizeBox = false;

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Miky", Value = "Manjiro.jpg" });
            comboBox1.Items.Add(new { Text = "Adum", Value = "AdumROR.jpg" });
            comboBox1.Items.Add(new { Text = "Baki", Value = "Baki.jpg" });
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Adum.png");
            Image img = Image.FromFile(imagePath);
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConDB db = new ConDB();

            string name = textBox4.Text;
            string user = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;

            // เช็คว่า Name หรือ User ซ้ำหรือไม่
            if (db.IsNameExist(name))
            {
                MessageBox.Show("Name ซ้ำ!");
                return;
            }

            if (db.IsUserExist(user))
            {
                MessageBox.Show("User Name ซ้ำ!");
                return;
            }

            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = (comboBox1.SelectedItem as dynamic).Value;
                string imageFileName = selectedValue;

                if (name != "" && user != "" && password != "" && confirmPassword != "")
                {
                    if (password == confirmPassword)
                    {
                        bool result = db.AddPlayer(name, user, password, imageFileName);
                        if (result)
                        {
                            MessageBox.Show("สมัครสำเร็จ!");
                            Form1 nextForm = new Form1();
                            nextForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดในการสมัคร!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("รหัสผ่านทั้งสองไม่ตรงกัน!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("คุณลืมใส่อะไรไปรึป่าววว!");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกตัวละครด้วย!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Hide();
        }
    }
}
