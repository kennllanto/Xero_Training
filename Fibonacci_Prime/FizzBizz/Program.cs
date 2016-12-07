using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        // 2.Build a fizz buzz program between the numbers 
        // 0 and 100 https://en.wikipedia.org/wiki/Fizz_buzz
        static void Main(string[] args)
        {
            int Fizz = 3;
            int Buzz = 5;
            for (int i = 0; i <= 100; i++)
            {
                if (((i % Fizz) != 0) && ((i % Buzz) != 0) )
                {
                    Console.WriteLine(i);
                }
                if ( (i % Fizz) == 0 )
                {
                    Console.Write("Fizz");
                }
                if ((i % Buzz) == 0)
                {
                    Console.Write("Buzz");
                }     
            }
            Console.ReadKey();
        }
    }
}
