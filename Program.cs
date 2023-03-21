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
            char[] patternRnd = new char[length];
            if (!pattern.Contains('l'))
            {
                patternPad = patternPad.Replace('l', args[1][0]);
            }

            for (int i = 0; i < patternPad.Length; i++)
            {
                switch (patternPad[i])
                {
                    case 'l':
                        patternRnd[i] = GetLowerCase();
                        break;
                    case 'L':
                        patternRnd[i] = GetUpperCase();
                        break;
                    case 'd':
                        patternRnd[i] = GetNumber();
                        break;
                    case 's':
                        patternRnd[i] = GetSpecial();
                        break;

                }
            }
            string generatedPassword = new string(patternRnd);
            Console.WriteLine($@"Suggested password:
                                {generatedPassword}");


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

}