using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces
{
    public class SavingsAccount: Account
    {
        public double InterestRate { get; set; }

        //i am forced to implement the Withdraw
        public override double Withdraw(double amount, string recipient)
        {
            if (amount > Balance)
            {
                Balance -= amount;

                Transaction myTransaction = new Transaction();
                myTransaction.Amount = amount;
                myTransaction.Destination = recipient;
                myTransaction.Source = IBAN; //being read from the inherited properties
                myTransaction.Timestamp = DateTime.UtcNow;
                myTransaction.Type = TransactionType.Withrawal;
                Transactions.Add(myTransaction);
            }

            return Balance;
        }
    }
}
