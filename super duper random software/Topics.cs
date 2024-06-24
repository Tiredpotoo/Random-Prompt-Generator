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
    public partial class Topics : Form
    {
        public Topics()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[0];
            globals.m.changeLabel();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[1];
            globals.m.changeLabel();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[2];
            globals.m.changeLabel();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[3];
            globals.m.changeLabel();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[4];
            globals.m.changeLabel();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[5];
            globals.m.changeLabel();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            globals.CHOSENTOPIC = "Chosen Topic\n" + globals.TOPICS[rand.Next(0, 5)];
            globals.m.changeLabel();
            this.Close();
        }
    }
}
