using MySql.Data.MySqlClient;
using System.Data;

namespace FlappyXmySQL
{
    public class ConDB
    {
        private string connectionString = "Server=localhost;Database=flappydb;Uid=root;Pwd='';Connect Timeout=3000";
        public class Player
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
            public string Images { get; set; }
            public string HighScore { get; set; }

        }


        // 0. CHEACK: เชคเชื่อม sql
        public bool CanConnect()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }

        // 1. CREATE: เพิ่มข้อมูลใหม่
        public bool AddPlayer(string name, string user, string password, string image)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Players (Name, User, Password, Images) VALUES (@Name, @User, @Password, @Images)";
                //MySqlCommand เป็นคลาสที่ใช้ใน ADO.NET เพื่อระบุคำสั่ง SQL ที่จะทำงานกับฐานข้อมูล MySQL ผ่านการใช้ MySqlConnection
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Images", image);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        // 2.1. READ: ดึงข้อมูลของ User นั้นๆ
        public Player GetPlayerData(string user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Players WHERE User = @User", conn);
                cmd.Parameters.AddWithValue("@User", user);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Player player = new Player
                    {
                        ID = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        User = reader["User"].ToString(),
                        Password = reader["Password"].ToString(),
                        Images = reader["Images"].ToString(),
                        HighScore = reader["HighScore"].ToString()
                    };
                    return player;
                }
                return null;
            }
        }


        // 2.2. READ: ดึงข้อมูลทั้งหมดเรียงตามคะแนน HighScore
        public DataTable GetAllPlayersHighScore() //DataTable  เป็นคลาสใน .NET Framework ที่ใช้เพื่อเก็บข้อมูลในรูปแบบของตาราง (table)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM players ORDER BY highscore DESC", conn);
                //ใช้เพื่อดึงข้อมูลจากฐานข้อมูล MySQL และนำข้อมูลนั้นมาเติมใน DataTable หรือ DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //.Fill() เป็นเมทอดที่ใช้กับ MySqlDataAdapter ใน .NET Framework เพื่อเติมข้อมูลจากแหล่งข้อมูลไปยัง DataTable หรือ DataSet
                adapter.Fill(dt);
                return dt;
            }
        }


        // 3. UPDATE: อัปเดตข้อมูล
        public bool UpdatePlayer(string id, string name, string user, string password, string image ,string highScore)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Players SET Name = @Name, User = @User, Password = @Password, Images = @Images ,HighScore = @HighScore  WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Images", image);
                cmd.Parameters.AddWithValue("@HighScore", highScore);

                //cmd.ExecuteNonQuery() เป็นเมทอดที่ใช้ใน ADO.NET เพื่อประมวลผลคำสั่ง SQL ที่ไม่ได้ return ข้อมูล (non-query) บนฐานข้อมูล, ซึ่งมักใช้สำหรับการทำงานกับคำสั่ง SQL ที่เป็น DML (Data Manipulation Language) เช่น INSERT, UPDATE, DELETE.
                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        // 4. DELETE: ลบข้อมูล
        public bool DeletePlayer(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Players WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        //LOGIN: ล็อคอินเชคข้อมูล
        public bool IsValidUser(string user, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Players WHERE User = @user AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);
                //แปลงค่าเป็น INT เพื่อตรวจสอบแล้ว รีเทิร์นเป็นบูลลีน
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        //SIGNUP: เชคข้อมูล Name
        public bool IsNameExist(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Players WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        //SIGNUP: เชคข้อมูล User
        public bool IsUserExist(string user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Players WHERE User = @User", conn);
                cmd.Parameters.AddWithValue("@User", user);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
