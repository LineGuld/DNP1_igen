using System;
using System.Collections.Generic;

namespace e2_fileStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tina = new Person("Tina", "Hadberg", 20, 1.70, false, 'F', 
                new[] {"Strik", "Grafitti", "Hest"});
            Person Stefan = new Person("Stefan", "Knudsen", 37, 2.01, false, 'M',
                new[] {"Have", "Smølf"});
            Person Frederik = new Person("Frederik", "Bergmann", 30, 1.85, true, 'M',
                new[] {"Dark Souls", "Voksenting"});

            List<Person> peeps = new List<Person>(){Tina, Stefan, Frederik};
            
            PersonPersistence.storeObject(peeps);
            var jsonback =  PersonPersistence.readObject();
        }
    }
}