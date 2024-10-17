namespace _5.passing_by_value_and_passing_by_reference
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
            Console.WriteLine("Enter original value: ");
            int original = int.Parse(Console.ReadLine());

            ModifyByValue(original);
            Console.WriteLine($"Value after ModifyByValue: {original}" );

            ModifyByReference(ref original);
            Console.WriteLine($"Value after ModifyByRefrence: {original}");
        }
        public void ModifyByValue(int value) {
            value = 10;
            Console.WriteLine($"Modified by value: {value}");
        }

        public void ModifyByReference(ref int value) {
            value = 10;
            Console.WriteLine($"modified by reference: {value}");   
        }
    }
}
