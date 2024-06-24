namespace super_duper_random_software
{
    partial class menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.MediumTurquoise;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(346, 226);
            button1.Name = "button1";
            button1.Size = new Size(368, 73);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(346, 326);
            button2.Name = "button2";
            button2.Size = new Size(368, 73);
            button2.TabIndex = 1;
            button2.Text = "Topics";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(346, 420);
            button3.Name = "button3";
            button3.Size = new Size(368, 73);
            button3.TabIndex = 2;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(276, 79);
            label1.Name = "label1";
            label1.Size = new Size(481, 144);
            label1.TabIndex = 3;
            label1.Text = "Random Prompt Generator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(702, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(769, 214);
            label2.Name = "label2";
            label2.Size = new Size(193, 49);
            label2.TabIndex = 6;
            label2.Text = "Chosen Topic\r\nArchitecture\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1045, 621);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // menu
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 607);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            ForeColor = Color.Gray;
            Name = "menu";
            Text = "menu";
            Load += menu_Load;
            //Resize += menu_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}