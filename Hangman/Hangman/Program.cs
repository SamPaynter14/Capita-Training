using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Words w = new Words();
            Answers a = new Answers();
            Guesses g = new Guesses();
            Drawing d = new Drawing();

            string word = w.getWord();

            int count = 0;

            Console.WriteLine($"The length of the word is {word.Length}");
            Console.WriteLine($"The word: {a.SetAns(word.Length)}");

            var Characters = new List<char>();

            foreach(char c in word)
            {
                Characters.Add(c);
            }

            int mistakes = 0;

            while(mistakes < 10)
            {
                bool changed = false;

                foreach(string str in a.GetAns())
                {
                    Console.Write($"{str} ");
                }
                Console.WriteLine();
                Console.WriteLine("Enter a letter: ");

                char guess = Console.ReadLine()[0];

                g.SetGuesses(guess);
              
                int pos;

                foreach(char c in Characters)
                {
                  
                    if(c == guess)
                    {
                        pos = Characters.IndexOf(c);
                        a.ChangeAns(pos, guess);
                        changed = true;
                    }
                }

                if(changed == false)
                {
                    mistakes++;
                }
                else
                {
                    count++;
                }
                
                d.Stickman(mistakes);





                if (count == word.Length)
                    break;
                

                
            }
            Console.WriteLine($"The word was {word} ");
            Console.ReadLine();

            
        }
    }
}
