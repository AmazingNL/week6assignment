

namespace _6.properties_with_private_setters
{
    internal class Product
    {
        public string Name { set; get; }
        public double Price {private set; get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;  
        }

        public void ProductDetails() {
            Console.WriteLine("Product Details");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }

    }
}
