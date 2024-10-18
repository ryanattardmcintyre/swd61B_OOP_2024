using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces
{
    //An abstract class allows the developer to
    //1. implement some members while postpone the implementation of others to the inherited clases
    //2. it cannot be initialized  so we create an abstract class to be inherited
    public abstract class Account
    {
         
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public string HolderIdCard { get; set; }


        //since i don't know all the details
        //how this method is going to work out
        //we can postpoine the implementation into
        //the inherited classes
        public abstract double Withdraw(double amount, string recipient);
       

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }



    }
}
