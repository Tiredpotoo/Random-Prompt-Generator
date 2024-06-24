namespace super_duper_random_software
{
    partial class Random_Anything
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Random_Anything));
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
            label8.BackColor = Color.DarkOrange;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(553, 304);
            label8.Name = "label8";
            label8.Size = new Size(232, 57);
            label8.TabIndex = 38;
            label8.Text = "Answer";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(292, 304);
            label6.Name = "label6";
            label6.Size = new Size(232, 57);
            label6.TabIndex = 37;
            label6.Text = "Answer";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOrange;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 304);
            label5.Name = "label5";
            label5.Size = new Size(232, 57);
            label5.TabIndex = 36;
            label5.Text = "Answer";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(553, 210);
            label3.Name = "label3";
            label3.Size = new Size(232, 57);
            label3.TabIndex = 35;
            label3.Text = "Prompt 3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(292, 210);
            label2.Name = "label2";
            label2.Size = new Size(232, 57);
            label2.TabIndex = 34;
            label2.Text = "Prompt 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(15, 210);
            label1.Name = "label1";
            label1.Size = new Size(232, 57);
            label1.TabIndex = 33;
            label1.Text = "Prompt 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(278, 89);
            button1.Name = "button1";
            button1.Size = new Size(270, 69);
            button1.TabIndex = 32;
            button1.Text = "Randomize!!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Random_Anything
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
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
            ForeColor = Color.Gold;
            Name = "Random_Anything";
            Text = "Random_Anything";
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