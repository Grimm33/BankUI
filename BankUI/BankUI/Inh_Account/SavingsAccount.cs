using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    public class SavingsAccount:Account
    {
        public SavingsAccount(string accName, float amtInAcc) :
            base(accName, amtInAcc)
        {

        }

        public void Deposit(float m)
        {
            base.Deposit(m);
        }
        
        public void CheckBalance()
        {
            base.CheckBalace();
        }
    }
}
