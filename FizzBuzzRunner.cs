using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz 
{
    static class FizzBuzzRunner 
    {
        static public object Next(int ordinal)
        {
            var m = new List<Func<int, String>>()
            {
                i => i % 3 == 0 ? "Fizz" : "",
                i => i % 5 == 0 ? "Buzz" : ""
            };

            var result = m.Aggregate("", (prod, next) => prod + next(ordinal));

            return result == "" ? (object)ordinal : (object)result;
        }
    }
}