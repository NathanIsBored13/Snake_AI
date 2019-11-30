using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_AI
{
    public class Pill
    {
        public int[] position { get; set; }
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
                position = new int[2] { random.Next(0, Settings.bord_size[0]), random.Next(0, Settings.bord_size[1]) };
            } while (snake.body.Any(x => x == position));
        }
    }
}
