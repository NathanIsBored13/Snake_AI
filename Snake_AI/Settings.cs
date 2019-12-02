
namespace Snake_AI
{
    public static class Settings
    {
        public static Vector bord_size { get; set; }
        public static VectorF cell_size { get; set; }
        public static int tick_speed { get; set; }
        public static void Initialise(float width, float height)
        {
            bord_size = new Vector(20, 20);
            tick_speed = 200;
            Calculate_Cell_Size(width, height);
        }
        public static void Calculate_Cell_Size(float width, float height)
        {
            cell_size = new VectorF(width / bord_size.x, height / bord_size.y);
        }
    }
}
