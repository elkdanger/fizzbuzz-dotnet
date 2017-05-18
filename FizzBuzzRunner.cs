using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz 
{
    static class FizzBuzzRunner 
    {
        static public string Next(int ordinal)
        {
            var m = new List<Func<int, String>>()
            {
                j => j % 3 == 0 ? "Fizz" : "",
                j => j % 5 == 0 ? "Buzz" : ""
            };

            var sb = new StringBuilder();

            for(var i = 1; i <= ordinal; i++) 
            {
                var result = m.Aggregate("", (prod, next) => prod + next(i));

                sb.Append(result == "" ? i.ToString() : result);
            }

            return sb.ToString();
        }
    }
}