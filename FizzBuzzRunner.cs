using System;

namespace FizzBuzz 
{
    static class FizzBuzzRunner 
    {
        static public object Next(int ordinal)
        {
            if (ordinal % 3 == 0)
                return "Fizz";
            else if (ordinal % 5 == 0)
                return "Buzz";
                
            return ordinal;
        }
    }
}