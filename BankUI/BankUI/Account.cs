using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    public class Account
    {
        string accName;
        public float amtInAcc;

        public Account(string accName, float amtInAcc)
        {
            this.accName = accName;
            this.amtInAcc = amtInAcc;
        }

        //deposits money in account
        protected void Deposit(float m)
        {
            amtInAcc += m;
        }

        //withdraws money from account
        protected void Withdraw(float m)
        {
            amtInAcc -= m;
        }

        //check amount of money in account
        protected float CheckBalace()
        {
            return amtInAcc;
        }
    }
}
