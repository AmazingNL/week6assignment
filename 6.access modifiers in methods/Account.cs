

namespace _6.access_modifiers_in_methods
{
    internal class Account
    {
        private string _accounthoulder;
        private double _amount;
        public Account(string accountHoulder)
        {
            _accounthoulder = accountHoulder;

        }
        public void Deposit (double amount)
        {
            LogTransaction(" ");
            _amount = amount;
            if (_amount > 0)
            {
                Console.WriteLine($"Deposit of {_amount} is successful ");
            }
            else Console.WriteLine("Not sucessful");
        }
        private void LogTransaction(string message) {
            Console.WriteLine("Purpose of your transfer:");
            message = Console.ReadLine();   
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account houlder name: {_accounthoulder}");
            Console.WriteLine($"Acount balace: {_amount}");
        }

    }
}
