using System;
using System.Collections.Generic;

namespace Snake_AI
{
    public class Snake
    {
        private byte direction { get; set; }
        public List<int[]> body { get; set; }
        public Pill pill { get; set; }
        public bool alive { get; set; }
        public Snake()
        {
            body = new List<int[]>();
            body.Add(new int[2] { (int)Math.Floor((double)Settings.bord_size[0] / 2), (int)Math.Floor((double)Settings.bord_size[1] / 2) });
            pill = new Pill(this);
            direction = 3;
            alive = true;
        }
        public void Move()
        {
            int[] head = body[body.Count - 1];
            Check_Collisions(head);
            if (alive)
            {
                body.Add(new int[2] { head[0] += direction == 2 ? -1 : (direction == 4 ? 1 : 0), head[1] += direction == 1 ? -1 : (direction == 3 ? 1 : 0) });
                body.RemoveAt(0);
            }
        }
        public void Check_Collisions(int[] check)
        {
            if (check[0] < 1 || check[0] > Settings.bord_size[0] - 2 || check[1] < 1 || check[1] > Settings.bord_size[1] - 2)
            {
                Console.WriteLine("Died");
                alive = false;
            }
        }
    }
}