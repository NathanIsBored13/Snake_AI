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
            Settings.Initialise(Game_Board.Width, Game_Board.Height);
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
        private void Reset_Button_Click(object sender = null, EventArgs e = null)
        {
            snake = new Snake();
            direction_buffer = Direction.up;
            ticks = 0;
            Stop_Game();
            Draw();
        }
        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Stop_Game();
            Settings_Window settings_window = new Settings_Window();
            settings_window.ShowDialog();
            settings_window.Dispose();
            Clock.Interval = Settings.tick_speed;
            VectorF buffer = Settings.cell_size;
            Settings.Calculate_Cell_Size(Game_Board.Width, Game_Board.Height);
            if (buffer.x != Settings.cell_size.x && buffer.y != Settings.cell_size.y) Reset_Button_Click();
            Draw();
        }
        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (!game_state)
            {
                if (!snake.alive) Reset_Button_Click();
                Start_Game();
            }
            else Stop_Game();
        }
        private void Start_Game()
        {
            game_state = true;
            Start_Button.Text = "Pause";
            Start_Button.BackColor = Color.Red;
            Clock.Start();
            Clock_Tick();
        }
        private void Stop_Game()
        {
            game_state = false;
            Start_Button.Text = "Play";
            Start_Button.BackColor = Color.FromArgb(0, 192, 0);
            Clock.Stop();
        }
        private void Clock_Tick(object sender = null, EventArgs e = null)
        {
            ticks++;
            snake.direction = direction_buffer;
            snake.Move();
            Draw();
            if (!snake.alive)
            {
                Stop_Game();
            }
            if (Settings.bord_size.x * Settings.bord_size.y - snake.body.Count == 1)
            {
                Defeat_Window victoy_window = new Defeat_Window();
                victoy_window.ShowDialog();
                victoy_window.Dispose();
                Reset_Button_Click();
            }
        }
        private void Draw()
        {
            Score_Display.Text = string.Format("{0:000}", snake.body.Count);
            Ticks_Display.Text = string.Format("{0:000}", ticks);
            Generic_Display.Text = string.Format("{0}, {1}\n{2}, {3}\n{4}\n{5}", Settings.bord_size.x, Settings.bord_size.y, snake.body[snake.body.Count - 1].x, snake.body[snake.body.Count - 1].y, Settings.tick_speed, Settings.bord_size.x * Settings.bord_size.y - snake.body.Count - 1);
            Bitmap bitmap = new Bitmap(Game_Board.Width, Game_Board.Height);
            Graphics image = Graphics.FromImage(bitmap);
            image.FillRectangle(Brushes.Gray, 0, 0, Game_Board.Width, Game_Board.Height);
            for (int i = 0; i < snake.body.Count - 1; i++)
            {
                image.FillRectangle(snake.alive ? Brushes.ForestGreen : Brushes.Red, snake.body[i].x * Settings.cell_size.x + Settings.cell_size.x * 0.05f, snake.body[i].y * Settings.cell_size.y + Settings.cell_size.y * 0.05f, Settings.cell_size.x * 0.9f, Settings.cell_size.x * 0.9f);
                image.DrawLine(new Pen(snake.alive? Brushes.ForestGreen : Brushes.Red, (snake.body[i].x != snake.body[i + 1].x? Settings.cell_size.x : Settings.cell_size.y) * 0.9f), snake.body[i].x * Settings.cell_size.x + Settings.cell_size.x * 0.5f, snake.body[i].y * Settings.cell_size.y + Settings.cell_size.y * 0.5f, snake.body[i + 1].x * Settings.cell_size.x + Settings.cell_size.x * 0.5f, snake.body[i + 1].y * Settings.cell_size.y + Settings.cell_size.y * 0.5f);
            }
            image.FillRectangle(snake.alive ? Brushes.Blue : Brushes.Red, snake.body[snake.body.Count - 1].x * Settings.cell_size.x + Settings.cell_size.x * 0.05f, snake.body[snake.body.Count - 1].y * Settings.cell_size.y + Settings.cell_size.y * 0.05f, Settings.cell_size.x * 0.9f, Settings.cell_size.y * 0.9f);
            image.FillEllipse(Brushes.Orange, snake.pill.position.x * Settings.cell_size.x + Settings.cell_size.x * 0.1f, snake.pill.position.y * Settings.cell_size.y + Settings.cell_size.y * 0.1f, Settings.cell_size.x * 0.8f, Settings.cell_size.y * 0.8f);
            Game_Board.Image = bitmap;
        }
        private void Snake_Window_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (new Keys[4] { Keys.Up, Keys.Down, Keys.Left, Keys.Right }.Contains(e.KeyData))
            {
                e.IsInputKey = true;
            }
        }
        private void Snake_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && snake.direction != Direction.down) direction_buffer = Direction.up;
            else if (e.KeyCode == Keys.Down && snake.direction != Direction.up) direction_buffer = Direction.down;
            else if (e.KeyCode == Keys.Left && snake.direction != Direction.right) direction_buffer = Direction.left;
            else if (e.KeyCode == Keys.Right && snake.direction != Direction.left) direction_buffer = Direction.right;
            e.Handled = true;
        }
    }
}
