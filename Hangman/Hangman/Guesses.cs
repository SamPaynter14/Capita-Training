using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Guesses
    {
        List<char> Guess = new List<char>();
        public void SetGuesses(char c)
        {
            Guess.Add(c);
        }

        public List<char> GetGuesses()
        {
            return Guess;
        }
    }
}
