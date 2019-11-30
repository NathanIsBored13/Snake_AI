using System;
using System.Collections.Generic;

namespace Snake_AI
{
    public class Snake
    {
        private byte direction;
        public List<int[]> body;
        public bool alive { get; set; }
        public Snake()
        {
            body = new List<int[]>();
            body.Add(new int[2] { (int)Math.Floor((double)Settings.bord_size[0] / 2), (int)Math.Floor((double)Settings.bord_size[1] / 2) });
            direction = 1;
            alive = true;
        }
        public void Move()
        {
            int[] head = body[body.Count - 1];
            Console.WriteLine(direction);
            body.Add(new int[2] { head[0] += direction == 2 ? -1 : (direction == 4 ? 1 : 0), head[1] += direction == 1 ? -1 : (direction == 3 ? 1 : 0) });
            body.RemoveAt(0);
        }
        public void Check_Collisions()
        {
            int[] head = body[body.Count - 1];
            Console.WriteLine("{0}, {1}", head[0], head[1]);
            /*if (head[0] < 0 || head[0] > Settings.bord_size[0] - 1 || head[1] < 0 || head[1] > Settings.bord_size[1])
            {
                alive = false;
            }*/
        }
    }
}