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
    public partial class random_land : Form
    {
        public random_land()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label5.Text = globals.POI[rand.Next(0, globals.POI.Length)];
            label6.Text = globals.POI[rand.Next(0, globals.POI.Length)];
            label8.Text = globals.biome[rand.Next(0, globals.scene.Length)];
        }
    }
}
