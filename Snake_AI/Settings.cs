
namespace Snake_AI
{
    public static class Settings
    {
        public static int[] bord_size { get; set; }
        public static float[] cell_size { get; set; }
        public static int tick_speed { get; set; }
        public static void Initialise(float width, float height)
        {
            bord_size = new int[2] { 20, 20 };
            cell_size = new float[2] { width / bord_size[0], height / bord_size[1] };
            tick_speed = 250;
        }
    }
}
