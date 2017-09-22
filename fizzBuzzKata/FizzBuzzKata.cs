using System.Collections.Generic;
using System.Linq;


namespace fizzBuzzKata
{
    public class FizzBuzzKata
    {
        public List<string> Calculate(List<string> numbers)
        {
            return numbers.Select(ParseNumber).ToList();
        }

        private static string ParseNumber(string n)
        {
            if (IsMultipleOfThreeAndFive(n)) return "FizzBuzz";
            if (IsMultipleOfThree(n)) return new Fizz().getName();
            if (IsMultipleOfFive(n)) return new Buzz().getName();
            return n;
        }

        private static bool IsMultipleOfThreeAndFive(string n)
        {
            return IsMultipleOfThree(n) && IsMultipleOfFive(n);
        }

        private static bool IsMultipleOfFive(string n)
        {
            return int.Parse(n) % 5 == 0;
        }

        private static bool IsMultipleOfThree(string n)
        {
            return int.Parse(n) % 3 == 0;
        }
    }
}