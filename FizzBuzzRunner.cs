using System;

namespace FizzBuzz 
{
    static class FizzBuzzRunner 
    {
        static public object Next(int ordinal)
        {
            if (ordinal % 3 == 0 && ordinal % 5 == 0)
                return "FizzBuzz";
            if (ordinal % 3 == 0)
                return "Fizz";
            if (ordinal % 5 == 0)
                return "Buzz";

            return ordinal;
        }
    }
}