using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Words
    {
       
        public string getWord()
        {
            string[] arrayWords = { "computer", "space", "cheese", "speak", "quiet", "jazz", "xylophone", "master", "orange", "jumper" };

            Random r = new Random();

            int rnd = r.Next(arrayWords.Length);

            string word = arrayWords[rnd];

            return word;
        }
    }
}
