using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_AI
{
    public class Snake
    {
        public Direction direction { get; set; }
        public List<Vector> body { get; set; }
        public Pill pill { get; set; }
        public bool alive { get; set; }
        public Snake()
        {
            body = new List<Vector>();
            body.Add(new Vector ((int)Math.Floor((double)Settings.bord_size.x / 2), (int)Math.Floor((double)Settings.bord_size.y / 2)));
            direction = Direction.up;
            pill = new Pill(this);
            alive = true;
        }
        public void Move()
        {
            Vector head = body[body.Count - 1];
            if (direction == Direction.right) head.x += 1;
            else if (direction == Direction.left) head.x += -1;
            else if (direction == Direction.down) head.y += 1;
            else if (direction == Direction.up) head.y += -1;
            Check_Collisions(head);
            if (alive)
            {
                body.Add(head);
                if (head.x == pill.position.x && head.y == pill.position.y) pill.Generate_Pill();
                else body.RemoveAt(0);
            }
        }
        public void Check_Collisions(Vector check)
        {
            if (check.x < 0 || check.x > Settings.bord_size.y - 1 || check.y < 0 || check.y > Settings.bord_size.x - 1)
            {
                alive = false;
            }
            if (body.Any(x => x.x == check.x && x.y == check.y)) alive = false;
        }
    }
}