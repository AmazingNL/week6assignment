namespace _9.Rectangle_with_validations
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
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new(width, height);
            rectangle.ReturnRectangle();
        }
    }
}
