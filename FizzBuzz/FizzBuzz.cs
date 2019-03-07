using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Output;

        public FizzBuzz(int number)
        {
            Output = number % 3 == 0 ? "Fizz" : string.Empty;
            Output += number % 5 == 0 ? "Buzz" : string.Empty;
            Output = Output.Length == 0 ? number.ToString() : Output;
        }

    }
}
