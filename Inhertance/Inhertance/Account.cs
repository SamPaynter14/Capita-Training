using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Account : Person //Inheritace
    {
        //Constructor
        public Account() { } 
        public double getAccountBalance() // method
        {
            return currentAccount;
        }

        public double setAccountBalance(double amount)
        {
            currentAccount = currentAccount + amount;
            return currentAccount;
        }

        public double withdrwawFromAccount(double amountToWithdraw)
        {
            currentAccount = currentAccount - amountToWithdraw;
            return currentAccount;

        }
    }

}
