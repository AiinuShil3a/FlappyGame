namespace FlappyGame
{
    partial class Home
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
            Start = new Button();
            Option = new Button();
            LogOut = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.MediumSeaGreen;
            Start.ForeColor = SystemColors.Control;
            Start.Location = new Point(313, 114);
            Start.Name = "Start";
            Start.Size = new Size(163, 51);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Option
            // 
            Option.BackColor = Color.Orange;
            Option.ForeColor = SystemColors.Control;
            Option.Location = new Point(313, 171);
            Option.Name = "Option";
            Option.Size = new Size(163, 51);
            Option.TabIndex = 1;
            Option.Text = "Option";
            Option.UseVisualStyleBackColor = false;
            Option.Click += Option_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Red;
            LogOut.ForeColor = SystemColors.Control;
            LogOut.Location = new Point(313, 299);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(163, 51);
            LogOut.TabIndex = 3;
            LogOut.Text = "Log out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 4;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(563, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 449);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogOut);
            Controls.Add(Option);
            Controls.Add(Start);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Option;
        private Button LogOut;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}