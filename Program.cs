namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (!PreCheck.CheckIfConditionsAreMet(args))
            {
                PreCheck.ShowReEnterArguments();
                return;
            }


            string pattern = args[1];
            int length = Convert.ToInt32(args[0]);
            string patternPad = pattern.PadLeft(length, GetLowerCase());
            Console.WriteLine(patternPad);


        }

        static char GetLowerCase()
        {
            int rangeLow = 97;
            int rangeHigh = 123;
            return (char)Randomizer.GetRandom(rangeLow, rangeHigh);
        }
    }
}