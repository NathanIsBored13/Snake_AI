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
            Tick_Speed_Input.Value = Settings.tick_speed/50;
        }
        private void Tick_Speed_Input_Scroll(object sender, EventArgs e)
        {
            Tick_Speed_Display.Text = string.Format("{0}ms", (Tick_Speed_Input.Value * 50).ToString());
        }
        private void Set_Button_Click(object sender, EventArgs e)
        {
            Board_Size_Error.SetError(Static1, "");
            Settings.tick_speed = Tick_Speed_Input.Value * 50;
            Regex regex = new Regex(@"^[\D]*[\d]+[\D]+[\d]+[\D]*$");
            Match match = regex.Match(Bord_Size_Input.Text);
            if (match.Success)
            {
                regex = new Regex(@"[\d]+");
                match = regex.Match(Bord_Size_Input.Text);
                Vector buffer = new Vector (Convert.ToInt32(match.Value), Convert.ToInt32(match.NextMatch().Value));
                if (buffer.x > 1 && buffer.y > 1) Settings.bord_size = buffer;
                else
                {
                    Board_Size_Error.SetError(Static1, "Each valume must be greater than 1"); 
                }
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
