using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingCLI
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int ReceiverID { get; set; }
        public double Amount { get; set; }
        public override string ToString()
        {
            return $"TransactionID: {TransactionID}, AccountID: {AccountID}, ReceiverID: {ReceiverID}, Amount: {Amount}";
        }
    }
}
