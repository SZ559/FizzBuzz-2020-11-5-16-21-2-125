using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Say(int count)
        {
            var word = string.Empty;

            word = NewMethod(count, word);

            return string.IsNullOrEmpty(word) ? count.ToString() : word;
        }

        private string NewMethod(int count, string word)
        {
            if (count % 3 == 0)
            {
                word += "Fizz";
            }

            if (count % 5 == 0)
            {
                word += "Buzz";
            }

            if (count % 7 == 0)
            {
                word += "Whizz";
            }

            return word;
        }
    }
}
