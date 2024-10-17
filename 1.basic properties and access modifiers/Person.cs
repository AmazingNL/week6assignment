

namespace _1.basic_properties_and_access_modifiers
{
    internal class Person
    {
        private string _name;
        private int _age;

        public Person(string Name, int Age)
        {
            _name = Name;
            _age = Age;
        }
        public string Name
        {
            get { return _name; 
            }
            set { _name = value; }
        }
        public int Age 
        { 
            get { return _age; 
            } 
            set { _age = value; }
        }

        public void Return()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

    }

   
}
