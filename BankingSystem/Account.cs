using System.Globalization;

namespace BankingSystem {
    class Account {

        public string Name { get; private set; }
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string name, int number, double balance) {
            Name = name;
            AccountNumber = number;
            Balance = balance;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }

        public double GetBalance() {
            return Balance;
        }

        public string GetName() {
            return Name;
        }

        public override string ToString() {
            return AccountNumber
                + ", "
                + Name
                + ", "
                + Balance.ToString("F3", CultureInfo.InvariantCulture);
        }

    }
}
