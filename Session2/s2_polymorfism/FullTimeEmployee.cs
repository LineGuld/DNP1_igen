namespace s2_polymorfism
{
    public class FullTimeEmployee: Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.MonthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}