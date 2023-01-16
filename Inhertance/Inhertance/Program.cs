using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account class
            Account myAccount = new Account();

            double currentAmount = 0.0;

            currentAmount = myAccount.setAccountBalance(1000.00);

            Console.WriteLine($"Current amount : {currentAmount}");

            currentAmount = myAccount.withdrwawFromAccount(200.00);

            Console.WriteLine($"Current amount : {currentAmount}");

            currentAmount = myAccount.getAccountBalance();

            Console.WriteLine($"Current amount : {currentAmount}");
            Console.ReadLine();
        }
    }
}
