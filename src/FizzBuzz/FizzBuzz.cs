using System;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Judge(int i)
        {
            var s = Convert.ToString(i);
            if (i <= 0) return s;

            var fizzBuzzArray = new[,] {{s, "Buzz"}, {"Fizz", "FizzBuzz"}};

            var f = i % 3 == 0;
            var b = i % 5 == 0;
            return fizzBuzzArray[Convert.ToInt32(f), Convert.ToInt32(b)];
        }
    }
}
