﻿namespace _1.basic_properties_and_access_modifiers
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
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person (name, age);

            person.Return();
        }
    }
}
