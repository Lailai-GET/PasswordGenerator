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
            string patternPad = pattern.PadLeft(length, 'l');
            if (!pattern.Contains('l'))
            {
                patternPad.Replace('l', args[1][0]);
            }


        }

    }

    static char GetLowerCase()
    {
        int rangeLow = 97;
        int rangeHigh = 123;
        return (char)Randomizer.GetRandom(rangeLow, rangeHigh);
    }
    static char GetUpperCase()
    {
        int rangeLow = 65;
        int rangeHigh = 91;
        return (char)Randomizer.GetRandom(rangeLow, rangeHigh);
    }
    static char GetSpecial()
    {
        int rangeLow = 33;
        int rangeHigh = 48;
        return (char)Randomizer.GetRandom(rangeLow, rangeHigh);
    }
    static char GetNumber()
    {
        int rangeLow = 48;
        int rangeHigh = 58;
        return (char)Randomizer.GetRandom(rangeLow, rangeHigh);
    }
}