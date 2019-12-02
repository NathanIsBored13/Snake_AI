using System;
using System.Linq;

namespace Snake_AI
{
    public class Pill
    {
        public Vector position { get; set; }
        Random random;
        Snake snake;
        public Pill(Snake snake)
        {
            random = new Random();
            this.snake = snake;
            if (Settings.bord_size.x * Settings.bord_size.y - snake.body.Count > 1) Generate_Pill();
        }
        public void Generate_Pill()
        {
            do
            {
                position = new Vector(random.Next(0, Settings.bord_size.x), random.Next(0, Settings.bord_size.y));
            } while (snake.body.Any(x => x.x == position.x && x.y == position.y));
        }
    }
}
