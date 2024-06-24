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
    public partial class random_architecture : Form
    {
        public random_architecture()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label5.Text = globals.Aestetics[rand.Next(0, globals.Aestetics.Length)];
            label6.Text = globals.building[rand.Next(0, globals.building.Length)];
            label7.Text = globals.unique[rand.Next(0, globals.unique.Length)];
            label8.Text = globals.emotion[rand.Next(0, globals.emotion.Length)];
        }
    }
}
