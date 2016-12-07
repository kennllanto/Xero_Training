using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Prime
{
    class Program
    {
        /// <summary>
        /// Program generates Fibonacci sequence from 1-100 and prints the number if it is prime
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int Previous = 1;
            int Current = 1;
            for (int i = 1; i <= 100; /* do nothing */)
            {
                if((isPrime(i)) && (i > 1))
                {
                   Console.WriteLine("{0}", i);
                }
                i = Current + Previous;
                Previous = Current;
                Current = i;

                //Console.WriteLine("{0}", i);
            }
            Console.Read();
        }

        //1,1,2,3,5,8
        /// <summary>
        /// Checks if the given integer is prime
        /// </summary>
        /// <param name="iNum"></param>
        /// <returns></returns>
        static bool isPrime(int iNum)
        {
            double SquareRoot = Math.Sqrt(iNum);
            for (int i = 2; i <= SquareRoot; i++)
            {
                int iRem = iNum % i;
                if(iRem == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
