using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace super_duper_random_software
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //switch for each option in globals chosen topic
            switch(globals.CHOSENTOPIC)
            {
                case "Chosen Topic\nArchitecture":
                    random_architecture arch = new random_architecture();
                    arch.Show();
                    break;
                case "Chosen Topic\nCharacter":
                    random_char c = new random_char();
                    c.Show();
                    break;
                case "Chosen Topic\nLandscape":
                    random_land land = new random_land();
                    land.Show();
                    break;
                case "Chosen Topic\nAnything":
                    Random_Anything anything = new Random_Anything();
                    anything.Show();
                    break;
                case "Chosen Topic\nAction":
                    Random_Action action = new Random_Action();
                    action.Show();
                    break;
                case "Chosen Topic\nFunny":
                    random_funny fun = new random_funny();
                    fun.Show();
                    break;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //opens the topics tab
            Topics topics = new Topics();
            topics.Show();
            changeLabel();
        }
        public void changeLabel()
        {
            //updates the topics label
            label2.Text = globals.CHOSENTOPIC;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //opens the settings tab
            Settings set = new Settings();
            set.Show();
        }
        private void menu_Load(object sender, EventArgs e)
        {
            globals.m = this;
        }
    }
}