using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Snake_AI
{
    public partial class Snake_Window : Form
    {
        Snake snake;
        bool game_state = false;
        int ticks = 1;
        Direction direction_buffer;
        public Snake_Window()
        {
            InitializeComponent();
            Settings.Initialise(Game_Bord.Width, Game_Bord.Height);
            Clock.Interval = Settings.tick_speed;
            snake = new Snake();
            Draw();
        }
        private void Snake_Window_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(Snake_Window_PreviewKeyDown);
            }
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
                Start_Button.BackColor = Color.Red;
                Clock.Start();
                Clock_Tick();
            }
            else
            {
                Start_Button.Text = "Play";
                Start_Button.BackColor = Color.FromArgb(0, 192, 0);
                Clock.Stop();
            }
        }
        private void Clock_Tick(object sender = null, EventArgs e = null)
        {
            Focus();
            ticks++;
            snake.direction = direction_buffer;
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
            Generic_Display.Text = string.Format("{0}, {1}\n{2}, {3}\n{4}\n{5}\n{6}", Settings.bord_size[0], Settings.bord_size[1], snake.body[snake.body.Count - 1].x, snake.body[snake.body.Count - 1].y, Settings.tick_speed, "0", "0");
            Bitmap bitmap = new Bitmap(Game_Bord.Width, Game_Bord.Height);
            Graphics image = Graphics.FromImage(bitmap);
            image.FillRectangle(Brushes.Gray, 0, 0, Game_Bord.Width, Game_Bord.Height);
            for (int i = 0; i < snake.body.Count; i++)
            {
                image.FillRectangle(snake.alive? Brushes.Blue : Brushes.Red, Settings.cell_size[0] * snake.body[i].x, Settings.cell_size[1] * snake.body[i].y, Settings.cell_size[0], Settings.cell_size[1]);
            }
            image.FillEllipse(Brushes.Green, Settings.cell_size[0] * snake.pill.position.x, Settings.cell_size[1] * snake.pill.position.y, Settings.cell_size[0], Settings.cell_size[1]);
            Game_Bord.Image = bitmap;
        }
        private void Snake_Window_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (new Keys[] { Keys.Up, Keys.Down, Keys.Left, Keys.Right }.Contains(e.KeyData))
            {
                e.IsInputKey = true;
            }
        }
        private void Snake_Window_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("pressed");
            if (e.KeyCode == Keys.Up && snake.direction != Direction.down) direction_buffer = Direction.up;
            else if (e.KeyCode == Keys.Down && snake.direction != Direction.up) direction_buffer = Direction.down;
            else if (e.KeyCode == Keys.Left && snake.direction != Direction.right) direction_buffer = Direction.left;
            else if (e.KeyCode == Keys.Right && snake.direction != Direction.left) direction_buffer = Direction.right;
            e.Handled = true;
        }
    }
}

