﻿

namespace _3.class_with_private_field_and_properties
{
    internal class Car
    {
        private string _make;
        private string _model;
        private int _year;

        public Car( string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }
        public string Make {
            get { return _make; }
            set { _make = value; }
        }
        public string Model { 
            get { return _model; }
            set { _model = value; }
        }
        public int Year { 
            get { return _year; }
            set { _year = value; }
        }

        public void CarDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
