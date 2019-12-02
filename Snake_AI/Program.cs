using System;
using System.Windows.Forms;
namespace Snake_AI
{
    public struct Vector
    {
        public int x;
        public int y;
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public struct VectorF
    {
        public float x;
        public float y;
        public VectorF(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public enum Direction
    {
        up,
        down,
        left,
        right,
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Snake_Window());
        }
    }
}
