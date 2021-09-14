namespace s2_polymorfism
{
    public class PartTimeEmplyee : Employee
    {
        public double HourlyWage { get; set; }
        public int HoursPerMonth { get; set; }

        public PartTimeEmplyee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            this.HourlyWage = hourlyWage;
            this.HoursPerMonth = hoursPerMonth;
        }


        public override double GetMonthlySalary()
        {
            return HourlyWage * HoursPerMonth;
        }
    }
}