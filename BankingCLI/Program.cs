using System.IO;
using System.Text.Json;

namespace BankingCLI {
    class Program {
        static void Main(string[] args){

            string accountsJSON = ("data/accounts.json");
            string transactionsJSON = ("data/transactions.json");

            existOrCreate(accountsJSON);
            existOrCreate(transactionsJSON);

            Bank bank = new Bank();

            bank.LoadAccounts(accountsJSON);

            bank.LoadTransactions(transactionsJSON);

            bank.Start();

        }

        public static void existOrCreate(string filename)
        {
            string? dir = Path.GetDirectoryName(filename);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, JsonSerializer.Serialize(new string[] { }));
            }

        }
    }

}