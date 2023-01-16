using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Drawing
    {
        public void Stickman(int mistakes)
        {
            string empty = " ";
            string bott = "----------";
            string pole = "     |    ";
            string hook = "     -----";
            string line = "         |";
            string head = "         O";
            string body1 = "         |";
            string body2 = "|";
            string rLimb = "        /";
            string lLimb = @" \";
            



            switch (mistakes)
            {
                case 0:
                    Console.WriteLine(empty);
                    break;

                case 1:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(bott);
                    break;

                case 2:
                    for(int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;

                case 3:
                    Console.WriteLine(hook);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;

                case 4:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;

                case 5:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;

                case 6:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    Console.WriteLine(body1);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;

                case 7:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    Console.Write(rLimb);
                    Console.WriteLine(body2);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);

                    break;

                case 8:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    Console.Write(rLimb);
                    Console.Write(body2);
                    Console.WriteLine(lLimb);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);

                    break;

                case 9:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    Console.Write(rLimb);
                    Console.Write(body2);
                    Console.WriteLine(lLimb);
                    Console.Write(rLimb);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);

                    break;

                case 10:
                    Console.WriteLine(hook);
                    Console.WriteLine(line);
                    Console.WriteLine(head);
                    Console.Write(rLimb);
                    Console.Write(body2);
                    Console.WriteLine(lLimb);
                    Console.Write(rLimb);
                    Console.WriteLine(lLimb);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(pole);
                    }
                    Console.WriteLine(bott);
                    break;


            }


        }
    }
}
