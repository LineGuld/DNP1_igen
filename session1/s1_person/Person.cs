using System;

namespace s1_e1
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        
        public void Introduce()
        {
            Console.WriteLine($"Hello I am {Name}");
        }
    }
}