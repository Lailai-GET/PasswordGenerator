
namespace PasswordGenerator
{
    internal class PreCheck
    {
        public static bool CheckIfConditionsAreMet(string[] args)
        {
            if (!CheckForArgs(args))
            {
                return false;
            }
            string firstArg = args[0];
            string secondArg = args[1];
            if (arg1IsDigit(firstArg) && arg2IsCorrectLetters(secondArg))
            {
                return true;
            }
            else return false;

        }

        private static bool arg2IsCorrectLetters(string secondArg)
        {
            foreach (char c in secondArg)
            {
                if (c == 'l' || c == 'L' || c == 'd' || c == 's') continue;
                return false;
            }

            return true;

        }

        public static void ShowReEnterArguments()
        {
            Console.WriteLine(@"PasswordGenerator  
              Options:
                 - l = lower case letter
                 - L = upper case letter
                 - d = digit
                 - s = special character !""#$%&'+,-./
              Example: PasswordGenerator 14 lLssdd
                 Min. 1 lower case
                 Min. 1 upper case
                 Min. 2 special characters
                 Min. 2 digits");
        }

        private static bool arg1IsDigit(string firstArgs)
        {
            foreach (char c in firstArgs)
            {
                if (!char.IsDigit(c)) return false;
            }

            return true;
        }

        private static bool CheckForArgs(string[] args)
        {
            if (args.Length == 2)
            {
                return true;
            }
            else return false;
        }
    }
}