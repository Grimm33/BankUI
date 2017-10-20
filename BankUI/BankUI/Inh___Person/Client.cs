using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    public class Client:Person
    {
        public List<CheckingAccount> checkingList = new List<CheckingAccount>();
        public List<SavingsAccount> savingsList = new List<SavingsAccount>();

        public Client(string name, string surname, string idCard):
            base(name, surname, idCard)
        {

        }

        //transfering money from one account to another
        public void Transfer(Account a, Account b, float amount)
        {
            a.amtInAcc -= amount;
            b.amtInAcc += amount;
        }

        public void AddCheckingAccount(CheckingAccount ca)
        {
            checkingList.Add(ca);
        }

        public void AddSavingsAccount(SavingsAccount sa)
        {
            savingsList.Add(sa);
        }
    }
}