using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(100);

            Console.WriteLine("You have 5 guesses to get the correct number.");

            for(int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Guess {i} - Enter a number between 1 and 99: ");
                int guess = Convert.ToInt32(Console.ReadLine());


                if(guess > num)
                {
                    Console.WriteLine("Lower!");
                }
                else if(guess < num)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }

            Console.WriteLine($"The number was {num}");
            Console.ReadLine();
        }
    }
}
