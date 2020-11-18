using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Say(int count)
        {
            if (count % 3 == 0)
            {
                return "Fizz";
            }

            if (count % 5 == 0)
            {
                return "Buzz";
            }

            if (count % 7 == 0)
            {
                return "Whizz";
            }

            return count.ToString();
        }
    }
}
