using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class FizzBuzz
    {
        public static string GetAnswserFor(int number)

        {
            if (number != 0)
            {

                if ((IsMultipleOFthree(number)) && (IsMultipleOFFive(number)))
                    return "FizzBuzz";
                if (IsMultipleOFthree(number))
                    return "Fizz";
                if (IsMultipleOFFive(number))
                    return "Buzz";
            }

            return string.Empty;
        }

        private static bool IsMultipleOFthree(int number)
        {
            return number % 3 == 0;
        }
        private static bool IsMultipleOFFive(int number)
        {
            return number % 5 == 0;
        }
    }
}

