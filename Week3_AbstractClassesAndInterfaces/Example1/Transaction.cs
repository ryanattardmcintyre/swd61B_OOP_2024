using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces
{
    public enum TransactionType { Withrawal, Deposit}
    public class Transaction
    {
        public int Id { get; set; } 
        public DateTime Timestamp { get; set; }
        public double Amount { get; set; }
        public TransactionType Type { get; set; }

        public string Branch { get; set; }

        public string Source { get; set; }
        public string Destination { get; set; }


    }
}
