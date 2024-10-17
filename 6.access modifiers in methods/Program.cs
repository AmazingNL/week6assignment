namespace _6.access_modifiers_in_methods
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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Account accountName = new(name);

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());
            accountName.Deposit(amount);

            accountName.DisplayAccountInfo();
        }
    }
}
