using LINQTut03.Shared;

namespace LINQTut03.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            IEnumerable<Employee> empMale = employees.Where(x => x.Gender == "male");

            var empsSalaryOver300K = employees.Where(x => x.Salary >= 300_000);

            empMale.Print("Male Employees");

            empsSalaryOver300K.Print("Employees with Salary >= 300K");

            var empMaleInHRDepartment = 
                empMale.Where(e => e.Department.ToLowerInvariant() == "hr");

            empMaleInHRDepartment.Print("Male Employees in HR");

            Console.ReadKey();
        }
    }
}
