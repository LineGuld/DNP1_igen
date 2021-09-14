namespace s2_polymorfism
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public abstract double GetMonthlySalary();

        public Employee(string name)
        {
            Name = name;
        }
    }
}