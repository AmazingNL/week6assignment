namespace _3.class_with_private_field_and_properties
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
            Console.Write("Enter car make: ");
            string make = Console.ReadLine();
            Console.Write("Enter car model: ");
            string model = Console.ReadLine();
            Console.Write("Enter car year: ");
            int year = int.Parse(Console.ReadLine());

            Car details = new(make, model, year);

            details.CarDetails();
        }
    }
}
