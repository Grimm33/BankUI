using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    public abstract class Person
    {
        public string name;
        public string surname;
        public string idCard;

        public Person(string name, string surname, string idCard)
        {
            this.name = name;
            this.surname = surname;
            this.idCard = idCard;
        }

        //used to test if everything works
        public void Yell()
        {
            Console.WriteLine("{0} {1} {2}", name, surname, idCard);
        }

    }
}
