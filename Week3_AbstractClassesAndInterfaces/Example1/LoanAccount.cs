using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces
{
    public class LoanAccount : Account
    {
        public double Principal { get; set; }
        public double DebitInterestRate { get; set; }

        public DateTime TermExpiryDate { get; set; }

        public override double Withdraw(double amount, string recipient)
        {
            if (DateTime.UtcNow > TermExpiryDate
                && Balance >=0
                ) {

                Transaction myTransaction = new Transaction();
                myTransaction.Amount = Principal;
                //recipient will be predefined
                myTransaction.Destination = recipient;
                myTransaction.Source = IBAN; //being read from the inherited properties
                myTransaction.Timestamp = DateTime.UtcNow;
                myTransaction.Type = TransactionType.Withrawal;
                Transactions.Add(myTransaction);

                return Principal;
            }

            return Balance;
            
        }
    }
}
