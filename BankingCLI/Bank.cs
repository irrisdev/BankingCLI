

using System.Text.Json;
using System.Text.Json.Nodes;

namespace BankingCLI
{
    class Bank
    {

        private List<Account> accounts = new();
        private List<Transaction> transactions = new();

        public void LoadAccounts(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            accounts = JsonSerializer.Deserialize<List<Account>>(jsonString)!;
        }
        public void LoadTransactions(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonString)!;
        }

        public void Start()
        {
            accounts.ForEach(item => Console.WriteLine(item.ToString()));
            Console.WriteLine(transactions.Count);
        }

        private void register()
        {

        }

        private void login()
        {

        }

    }
}