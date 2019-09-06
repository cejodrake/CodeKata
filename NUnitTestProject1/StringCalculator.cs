using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeKata
{
    public class StringCalculator
    {
        public static int Sum(string input)
        {


            if (!string.IsNullOrEmpty(input))
            {
                var numbers = GetNumbersIntFromInput(input);

               

                var sumAllNumbers = GetSumAllNumbers(numbers);

                if (sumAllNumbers < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(sumAllNumbers),
                    "negatives not allowed:");
                }

                return sumAllNumbers;
            }


            return 0;
        }


        private static int GetNumbeTheSameNumber(List<string> numbers)
        {
            if (numbers.Count == 1)
            {
                foreach (var number in numbers)
                {
                    if (int.Parse(number) > 0)
                    {
                        return int.Parse(number);
                    }
                }

            }
            return 0;
        }
       


        private static List<string> GetNumbersIntFromInput(string input)
        {
            var newListNumbers = new List<string>();

            var numbers = Regex.Matches(input, @"-?\d+");

            if (numbers.Count != 0)
            {
                foreach (Match number in numbers)
                {
                    newListNumbers.Add(number.Value);
                }
              
                return newListNumbers;
            }
            return new List<string>();
      
        }

        private static int GetSumAllNumbers(List<string> numbers)
        {

            var sumNumbers = 0;

            foreach (string number in numbers)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    if (int.Parse(number) < 1000)
                    {
                        sumNumbers += int.Parse(number);
                    }

                }

            }
                return sumNumbers;
          
        }

    }
}
