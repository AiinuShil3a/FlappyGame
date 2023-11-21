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
    public partial class Update : Form
    {
        private Player _player;
        public Update(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConDB db = new ConDB();

            string name = textBox4.Text;
            string user = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;

            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = (comboBox1.SelectedItem as dynamic).Value;
                string imageFileName = selectedValue;

                if (name != "" && user != "" && password != "" && confirmPassword != "")
                {
                    if (name == _player.Name)
                    {
                        if (password == confirmPassword)
                        {
                            bool result = db.UpdatePlayer(_player.ID, name, _player.User, password, imageFileName, _player.HighScore);
                            if (result)
                            {
                                _player.Name = name;
                                _player.User = user;
                                _player.Password = password;
                                _player.Images = imageFileName;

                                MessageBox.Show("แก้ไขสำเร็จ!");
                                Home nextForm = new Home(_player);
                                nextForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข!");
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
                        // เช็คว่า Name
                        if (db.IsNameExist(name))
                        {
                            MessageBox.Show("Name ซ้ำ!");
                            return;
                        }
                        else
                        {
                            if (password == confirmPassword)
                            {
                                bool result = db.UpdatePlayer(_player.ID, name, _player.User, password, imageFileName, _player.HighScore);
                                if (result)
                                {
                                    _player.Name = name;
                                    _player.User = user;
                                    _player.Password = password;
                                    _player.Images = imageFileName;

                                    MessageBox.Show("แก้ไขสำเร็จ!");
                                    Home nextForm = new Home(_player);
                                    nextForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("รหัสผ่านทั้งสองไม่ตรงกัน!");
                                return;
                            }
                        }
                    }

                }
                else if (name != "" && user != "" && password == "" && confirmPassword == "")
                {
                    if (name == _player.Name)
                    {
                        bool result = db.UpdatePlayer(_player.ID, name, _player.User, _player.Password, imageFileName, _player.HighScore);
                        if (result)
                        {
                            _player.Name = name;
                            _player.User = user;
                            _player.Password = _player.Password;
                            _player.Images = imageFileName;

                            MessageBox.Show("แก้ไขสำเร็จ!");
                            Home nextForm = new Home(_player);
                            nextForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข!");
                        }
                    }
                    else
                    {
                        // เช็คว่า Name
                        if (db.IsNameExist(name))
                        {
                            MessageBox.Show("Name ซ้ำ!");
                            return;
                        }
                        else
                        {
                            bool result = db.UpdatePlayer(_player.ID, name, _player.User, _player.Password, imageFileName, _player.HighScore);
                            if (result)
                            {
                                _player.Name = name;
                                _player.User = user;
                                _player.Password = _player.Password;
                                _player.Images = imageFileName;

                                MessageBox.Show("แก้ไขสำเร็จ!");
                                Home nextForm = new Home(_player);
                                nextForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไขบางประการ!");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกตัวละครด้วย!");
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            //ไม่อนุญาติให้ขยายจอ
            this.MaximizeBox = false;

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Miky", Value = "Manjiro.jpg" });
            comboBox1.Items.Add(new { Text = "Adum", Value = "AdumROR.jpg" });
            comboBox1.Items.Add(new { Text = "Baki", Value = "Baki.jpg" });

            string imagePath = Path.Combine(Application.StartupPath, "Images", "BGMarrio.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile(imagePath);
            string imagePath1 = Path.Combine(Application.StartupPath, "Images", "Miky.png");
            Image img = Image.FromFile(imagePath1);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BackColor = Color.Transparent;
            textBox1.Text = _player.User;
            textBox4.Text = _player.Name;
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home BackForm = new Home(_player);
            BackForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจที่จะลบข้อมูลนี้หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ConDB db = new ConDB();
                bool result = db.DeletePlayer(_player.ID.ToString());
                if (result)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ!");
                    Form1 BackForm = new Form1();
                    BackForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล!");
                }
            }
        }

    }
}
