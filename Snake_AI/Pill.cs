using System;
using System.Linq;

namespace Snake_AI
{
    public class Pill
    {
        public Point position { get; set; }
        Random random;
        Snake snake;
        public Pill(Snake snake)
        {
            random = new Random();
            this.snake = snake;
            Generate_Pill();
        }
        public void Generate_Pill()
        {
            do
            {
                position = new Point (random.Next(0, Settings.bord_size[0]), random.Next(0, Settings.bord_size[1]));
            } while (snake.body.Any(x => x.x == position.x && x.y == position.y));
        }
    }
}
