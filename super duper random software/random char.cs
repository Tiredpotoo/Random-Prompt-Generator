using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_duper_random_software
{
    public partial class random_char : Form
    {
        public random_char()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label5.Text = globals.character[rand.Next(0, globals.character.Length)];
            label8.Text = globals.scene[rand.Next(0, globals.scene.Length)];
            label6.Text = globals.clothes[rand.Next(0, globals.clothes.Length)];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void random_char_Load(object sender, EventArgs e)
        {

        }
    }
}
