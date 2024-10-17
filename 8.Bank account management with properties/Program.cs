namespace _8.Bank_account_management_with_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
           program.Start();
        }
        void Start()
        {
            Console.WriteLine("Enter your bank account number: ");
            string number = Console.ReadLine();
            BankAccount account = new(number, 0);

            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());

            account.Withdraw(withdrawalAmount);

            account.DisplayAccountInfo();


        }
    }
}
