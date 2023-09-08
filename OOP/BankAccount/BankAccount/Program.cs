using System;

namespace BankAccount
{
    class Account
    {
        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public double Deposit { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return $" {FullName} account balance: {Balance}";
        }

        public Account(string fullName, string accountNumber,double deposit, double balance) 
        
        {
            FullName = fullName;
            AccountNumber = accountNumber;
            Deposit = deposit;
            Balance = balance;
        }

        public void Withdraw (int AmountWithdraw)
        {
            if (AmountWithdraw <= Balance) {

                Balance -= AmountWithdraw;

            }
           else
            {
                Console.WriteLine("You can't withdraw this amount, insufficient funds");
            }
                


        }
        public void MakeDeposit(int AmountDeposit)
        {
            Balance += AmountDeposit;
            Deposit = AmountDeposit;
        }


    }

    class Program
    {
        static void Main()
        {
            Account BrunoAccount = new Account("Bruno", "123456789", 20.0, 100.0);
            BrunoAccount.MakeDeposit(20);
            Console.WriteLine($"You have made a deposit of {BrunoAccount.Deposit}, your balance now is {BrunoAccount.Balance}");
            BrunoAccount.Withdraw(174);
            Console.WriteLine($"Your balance now  {BrunoAccount.Balance}");

            Account HeikkiAccount = new Account("Heikki", "0987654321", 0.0 ,1000.0);
            Account PersonalAccount = new Account("Personal", "0987123456", 0.0, 0.0);

            HeikkiAccount.Withdraw(100);
            PersonalAccount.MakeDeposit(100);
            Console.WriteLine(HeikkiAccount.ToString()); 
            Console.WriteLine(PersonalAccount.ToString());

        }



    }
}