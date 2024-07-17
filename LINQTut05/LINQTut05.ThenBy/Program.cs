using LINQTut05.Shared;

namespace LINQTut05.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var sortedEmployeesAsc = employees.OrderBy(e => e.Name).ThenBy(e => e.Salary);

            sortedEmployeesAsc.Print("sortedEmployees01");

            var sortedEmployeesDecsQ = from e in employees
                                    orderby e.Name descending, e.Salary
                                    descending select e;

            sortedEmployeesDecsQ.Print("sortedEmployeesDecsQ");

            Console.ReadKey();
        }
    }
}
