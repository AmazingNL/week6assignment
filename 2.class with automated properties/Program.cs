namespace _2.class_with_automated_properties
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
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author name: ");
            string author = Console.ReadLine();
            Book details = new(title, author);

            details.BookDetails();
        }
    }
}
