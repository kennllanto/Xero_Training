using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBizz
{
    class Program
    {
        // 2.Build a fizz buzz program between the numbers 0 and 100 https://en.wikipedia.org/wiki/Fizz_buzz
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0) )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( (i % 3) == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
