

namespace _8.Bank_account_management_with_properties
{
    internal class BankAccount
    {
        private string AccountNumber;
        private double Balance;

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public string accountNumber { 
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }
        public double balance {  
            get { return Balance; }
        }
        public void Deposit(double amount) // to deposite
        {
            if (amount > 0)
            {
                Balance += (double)amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Not successful");
            }
        }
        public void Withdraw(double amount) // to withdraw amount
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Withdraw not successful");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Details:");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:F2}");
        }
    }
}
