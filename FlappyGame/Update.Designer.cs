namespace FlappyGame
{
    partial class Update
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
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(382, 371);
            button3.Name = "button3";
            button3.Size = new Size(152, 42);
            button3.TabIndex = 24;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(602, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 303);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(230, 371);
            button1.Name = "button1";
            button1.Size = new Size(152, 42);
            button1.TabIndex = 22;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 291);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 21;
            label2.Text = "กรุณาเลือกตัวละคร";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(230, 318);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 23);
            comboBox1.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(230, 254);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "NAME CHARACTER";
            textBox4.Size = new Size(312, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 216);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "CONFIRM NEW PASSWORD ( IF YOU WANT )";
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 175);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "NEW PASSWORD ( IF YOU WANT )";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 137);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "USERNAME";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(230, 56);
            label1.Name = "label1";
            label1.Size = new Size(312, 49);
            label1.TabIndex = 15;
            label1.Text = "Update Character";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(636, 12);
            button2.Name = "button2";
            button2.Size = new Size(152, 42);
            button2.TabIndex = 25;
            button2.Text = "DELETE ID CLICK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Update";
            Text = "Update";
            Load += Update_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}