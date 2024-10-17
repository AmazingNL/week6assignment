

using System.Formats.Asn1;

namespace _9.Rectangle_with_validations
{
    internal class Rectangle
    {
        private double Width;
        private double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double width {
            get { return Width; } 
            set { Width = value; }
        }
        public double height
        {
            get { return Height; }
            set { Height = value; }
        }
        public double area
        {
            get { return Height * Width; }
        }
        public double perimeter { 
            get { return 2 * (Width + Height); }
        }

        public void ReturnRectangle()
        {
            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }

    }
}
