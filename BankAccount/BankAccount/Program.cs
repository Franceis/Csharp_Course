using System;
using System.Globalization;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {
            Account account;

            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the account holder name: ");
            string accountName = Console.ReadLine();

            Console.Write("Will there be an initial deposit (s/n)? ");
            char answer = char.Parse(Console.ReadLine());

            Console.WriteLine();

            if (answer == 's' || answer == 'S') {
                Console.Write("Enter the value for initial deposit: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(accountNumber, accountName, initialDeposit);
            }
            else {
                account = new Account(accountNumber, accountName);
            }

            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Enter a value to deposit: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Account data actualized:");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Enter a value to withdraw: ");
            account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Account data actualized: ");
            Console.WriteLine(account);
        }
    }
}
