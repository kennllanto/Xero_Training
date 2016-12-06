using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {

        //2.Write a console app with a loop to check if any integer between 0 and 100 is 
        //  PRIME - if it is display to the screen(Console.Writeline) otherwise ignore3.
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
          
        }
        static bool isPrime(int iNum)
        {
            double iSqRoot = Math.Sqrt(iNum);
            for (int i = 2; i <= iSqRoot; i++)
            {
                int iRem = iNum % i;
                if (iRem == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
