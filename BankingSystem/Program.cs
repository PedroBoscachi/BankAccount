using System;
using System.Collections.Generic;
using System.Globalization;

namespace BankingSystem {
    class Program {
        static void Main(string[] args) {

            List<Account> accounts = new List<Account>();

            for (int i = 0; i < 3; i++) {
                Console.Clear();
                Console.Write("Enter the name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the account number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Enter the balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                accounts.Add(new Account(name, number, balance));
            }

            Console.WriteLine();

            foreach (Account obj in accounts) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            bool end = false;

            do {
                Console.WriteLine();
                Console.WriteLine("----MENU----");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1- Show the accounts");
                Console.WriteLine("2- Deposit");
                Console.WriteLine("3- Withdraw");
                Console.WriteLine("4- Leave");
                Console.Write("-> ");
                string option = Console.ReadLine();

                switch (option) {

                    case "1":
                        foreach (Account obj in accounts) {
                            Console.WriteLine(obj);
                        }
                        break;
                    case "2":
                        Console.Write("Account number: ");
                        int searchNumber = int.Parse(Console.ReadLine());
                        Account option1 = accounts.Find(x => x.AccountNumber == searchNumber);
                        if (option != null) {
                            Console.Write("Enter the value: ");
                            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            option1.Deposit(value);
                        }
                        break;
                    case "3":
                        Console.Write("Account number: ");
                        int searchNumber2 = int.Parse(Console.ReadLine());
                        Account option2 = accounts.Find(x => x.AccountNumber == searchNumber2);
                        if (option != null) {
                            Console.Write("Enter the value: ");
                            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            option2.Withdraw(value);
                        }
                        break;
                    case "4":
                        end = true;
                        break;

                }
            } while (!end);
        }
    }
}
