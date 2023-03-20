
namespace PasswordGenerator
{
    internal class Randomizer
    {
        public static int GetRandom(int min, int max)
        {
            Random rnd = new Random();
            int num = rnd.Next(min, max);
            return num;
        }
    }
}
