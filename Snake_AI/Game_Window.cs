using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_AI
{
    public partial class Snake_Window : Form
    {
        Snake snake;
        bool game_state = false;
        int ticks = 1;
        public Snake_Window()
        {
            InitializeComponent();
            Settings.Initialise(Game_Bord.Width, Game_Bord.Height);
            snake = new Snake();
            Draw();
        }
        private void Reset_Button_Click(object sender, EventArgs e)
        {
            if (!game_state)
            {
                snake = new Snake();
                ticks = 0;
                Draw();
            }
        }
        private void Start_Button_Click(object sender = null, EventArgs e = null)
        {
            game_state = !game_state;
            if (game_state)
            {

                Start_Button.Text = "Pause";
                this.Start_Button.BackColor = System.Drawing.Color.Red;
                Clock.Start();
                Clock_Tick();
            }
            else
            {
                Start_Button.Text = "Play";
                this.Start_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                Clock.Stop();
            }
        }
        private void Clock_Tick(object sender = null, EventArgs e = null)
        {
            ticks++;
            snake.Move();
            Draw();
            if (!snake.alive)
            {
                Clock.Stop();
                Start_Button_Click();
            }
        }
        private void Draw()
        {
            Score_Display.Text = string.Format("{0:000}", snake.body.Count);
            Ticks_Display.Text = string.Format("{0:000}", ticks);
            Generic_Display.Text = string.Format("{0}, {1}\n{2}\n{3}\n{4}", Settings.bord_size[0], Settings.bord_size[1], Settings.tick_speed, "0", "0");
            Bitmap bitmap = new Bitmap(Game_Bord.Width, Game_Bord.Height);
            Graphics image = Graphics.FromImage(bitmap);
            image.FillRectangle(Brushes.Gray, 0, 0, Game_Bord.Width, Game_Bord.Height);
            for (int i = 0; i < snake.body.Count; i++)
            {
                image.FillRectangle(snake.alive? Brushes.Blue : Brushes.Red, Settings.cell_size[0] * snake.body[i][0], Settings.cell_size[1] * snake.body[i][1], Settings.cell_size[0], Settings.cell_size[1]);
            }
            image.FillEllipse(Brushes.Green, Settings.cell_size[0] * snake.pill.position[0], Settings.cell_size[1] * snake.pill.position[1], Settings.cell_size[0], Settings.cell_size[1]);
            Game_Bord.Image = bitmap;
        }
        
    }
}
