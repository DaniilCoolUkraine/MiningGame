namespace MiningGame.GridSystem.General
{
    public class Utils
    {
        public static int GetIndex(int x, int y, int width)
        {
            return y * width + x;
        }
    }
}