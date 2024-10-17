using System.Formats.Asn1;

namespace _4.calculated_properties
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
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            var area = new Circle(radius);
            area.DisplayInfo();
        }
    }
}
