using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame
{
    //3.Write a simple game(console app) to create a random number between 0 and 100. 
    //  The program will ask you for the number and will ask you each turns the number.
    //  If the number you select is > or<than the random number it will tell you this and
    //  get you to enter the number again (while incrementing the number of turns). 
    //  Eventually when you enter the correct the number it will display the number of turns.
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int iRandomGenerated = rnd.Next(0, 100);
            Console.WriteLine("Guess the number between 0 to 100:");
            int iNumOfGuesses = 0;
            bool isCorrect = false;
            do
            {

                int iGuess;
                if (int.TryParse(Console.ReadLine(), out iGuess))
                {
                    if ((iGuess >= 0) && (iGuess <= 100))
                    {
                        if (iGuess == iRandomGenerated)
                        {
                            isCorrect = true;
                        }
                        else if (iGuess > iRandomGenerated)
                        {
                            Console.WriteLine("Number is lower than your Guess. Try again.");
                        }
                        else
                        {
                            Console.WriteLine("Number is higher than your Guess. Try again.");
                        }
                        iNumOfGuesses++;
                    }
                    else
                    {
                        Console.WriteLine("The value entered is not between 0 to 100. Invalid Guess");
                    }

                }
                else
                {
                    Console.WriteLine("The value entered is not a valid number. Invalid Guess");
                }
            } while (!isCorrect);
            Console.WriteLine("You Win! The correct number is {1} It took you {0} guess!", iNumOfGuesses, iRandomGenerated);
            Console.ReadKey();
            {

            }
        }
    }
}
