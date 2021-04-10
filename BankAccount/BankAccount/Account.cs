using System.Globalization;

namespace BankAccount {
    class Account {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }

        public double Balance { get; private set; }

        private double _tax = 5.00;

        public Account(int accountNumber, string accountHolder) {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        public Account(int accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder) {
            Deposit(initialDeposit);
        }

        public void Deposit(double value) {
            Balance += value;
        }

        public void Withdraw(double value) {
            Balance -= _tax;
            Balance -= value;
        }

        public override string ToString() {
            return "Account "
                + AccountNumber
                + ", Holder: "
                + AccountHolder
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
