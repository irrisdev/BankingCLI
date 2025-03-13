
using System.Xml.Linq;

namespace BankingCLI {

   
    class Account {

        public int AccountID { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return $"AccountID: {AccountID}, Balance: {Balance}";
        }
    }
}