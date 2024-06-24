namespace super_duper_random_software
{
    partial class random_land
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(random_land));
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.Peru;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(553, 317);
            label8.Name = "label8";
            label8.Size = new Size(232, 57);
            label8.TabIndex = 31;
            label8.Text = "Answer";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Peru;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(292, 317);
            label6.Name = "label6";
            label6.Size = new Size(232, 57);
            label6.TabIndex = 30;
            label6.Text = "Answer";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Peru;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 317);
            label5.Name = "label5";
            label5.Size = new Size(232, 57);
            label5.TabIndex = 29;
            label5.Text = "Answer";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Olive;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(553, 223);
            label3.Name = "label3";
            label3.Size = new Size(232, 57);
            label3.TabIndex = 28;
            label3.Text = "Place";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Olive;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 223);
            label2.Name = "label2";
            label2.Size = new Size(232, 57);
            label2.TabIndex = 27;
            label2.Text = "P.O.I. #2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Olive;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 223);
            label1.Name = "label1";
            label1.Size = new Size(232, 57);
            label1.TabIndex = 26;
            label1.Text = "P.O.I. #1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button1.Location = new Point(292, 40);
            button1.Name = "button1";
            button1.Size = new Size(270, 69);
            button1.TabIndex = 25;
            button1.Text = "Randomize!!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // random_land
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "random_land";
            Text = "random_land";
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}