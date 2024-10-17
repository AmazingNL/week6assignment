

namespace _4.calculated_properties
{
    internal class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;  
        }

        public double Area {
            get {
                return (double)_radius * _radius * Math.PI;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Area: {Area:.00}");
        }
    }
}
