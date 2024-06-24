using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace super_duper_random_software
{
    public partial class random_funny : Form
    {
        public random_funny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label5.Text = globals.character[rand.Next(0, globals.character.Length)];
            label6.Text = globals.descriptor[rand.Next(0, globals.descriptor.Length)];
            label8.Text = globals.scene[rand.Next(0, globals.scene.Length)];
        }
    }
}
