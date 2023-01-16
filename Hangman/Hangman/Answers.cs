using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Answers
    {
        List<string> Answer = new List<string>();

        public List<string> SetAns (int length)
        {
            
            for( int i = 0; i < length; i++)
            {
                Answer.Add("-");
            }

            return Answer;
        }

        public void ChangeAns(int pos, char ans)
        {
            string answer = ans.ToString();
            Answer[pos] = answer;
        }

        public List<string> GetAns()
        {
            return Answer;
        }
    }
}
