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
    public partial class Random_Anything : Form
    {
        public Random_Anything()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label5.Text = globals.anything[rand.Next(0, globals.anything.Length)];
            label8.Text = globals.anything[rand.Next(0, globals.anything.Length)];
            label6.Text = globals.anything[rand.Next(0, globals.anything.Length)];
        }
    }
}
