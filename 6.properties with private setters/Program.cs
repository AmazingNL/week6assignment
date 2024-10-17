namespace _6.properties_with_private_setters
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
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());
            Product product = new Product(name, price);

            product.ProductDetails();
        }
    }
}
