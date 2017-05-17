using System;

namespace FizzBuzz 
{
    static class FizzBuzzRunner 
    {
        static public object Next(int ordinal)
        {
            if (ordinal % 3 == 0)
                return "Fizz";
                
            return ordinal;
        }
    }
}