using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Snake_AI
{
    public partial class Settings_Window : Form
    {
        public Settings_Window()
        {
            InitializeComponent();
            Tick_Speed_Display.Text = string.Format("{0}ms", Settings.tick_speed.ToString());
            Tick_Speed_Input.Value = Settings.tick_speed/100;
        }
        private void Tick_Speed_Input_Scroll(object sender, EventArgs e)
        {
            Tick_Speed_Display.Text = string.Format("{0}ms", (Tick_Speed_Input.Value * 100).ToString());
        }
        private void Set_Button_Click(object sender, EventArgs e)
        {
            Settings.tick_speed = Tick_Speed_Input.Value * 100;
            Regex regex = new Regex(@"^[\D]*[\d]+[\D]+[\d]+[\D]*$");
            Match match = regex.Match(Bord_Size_Input.Text);
            if (match.Success)
            {
                regex = new Regex(@"[\d]+");
                match = regex.Match(Bord_Size_Input.Text);
                Settings.bord_size[0] = Convert.ToInt32(match.Value);
                match = match.NextMatch();
                Settings.bord_size[1] = Convert.ToInt32(match.Value);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
