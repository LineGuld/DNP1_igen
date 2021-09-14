using System;

namespace s2_polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Company via = new Company();
            
            via.HireNewEmployee (new PartTimeEmplyee("Tina", 140,5 ));
            via.HireNewEmployee (new PartTimeEmplyee("Line", 140,3 ));
            via.HireNewEmployee (new FullTimeEmployee("Stefan", 5000 ));
            via.HireNewEmployee (new FullTimeEmployee("Frederik", 5000 ));
            
            Console.WriteLine(via.GetMonthlySalaryTotal());
        }
    }
}