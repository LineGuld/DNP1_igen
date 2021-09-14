using System.Collections.Generic;

namespace s2_polymorfism
{
    public class Company
    {
        public List<Employee> EmployeeList = new List<Employee>();

        public Company()
        {
        }

        public double GetMonthlySalaryTotal()
        {
            double salary = 0;

            foreach (var employee in EmployeeList)
            {
                salary += employee.GetMonthlySalary();
            }

            return salary;
        }

        public void HireNewEmployee(Employee emp)
        {
            EmployeeList.Add(emp);
        }
    }
}