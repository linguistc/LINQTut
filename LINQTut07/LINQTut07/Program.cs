
using LINQTut07.Shared;
using System.ComponentModel.DataAnnotations;

RunAny();
RunAll();
RunAllQuerySyntax();
RunContains();

static void RunAny()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++");
    Console.WriteLine("Run Any()");
    Console.WriteLine("+++++++++");
    Console.WriteLine();

    var employees = Repository.LoadEmployees();

    // if any employee name starts with some sequence of letter
    var input1 = "jac";
    var result1 = employees.Any(e => e.Name.StartsWith(input1, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine($"find employee with name starts with '{input1}' result: {result1}\n");

    // if any salary less than 10000
    var input2 = 10000;
    var result2 = employees.Any(e => e.Salary < input2);
    Console.WriteLine($"at least one employee with salary less than {input2.ToString("C2")} result: {result2}\n");


    // if any employee with skills less than 1
    var noOfSkills = 1;
    var result3 = employees.Any(e => e.Skills.Count < noOfSkills);
    Console.WriteLine($"at least one employee with skill count less than {noOfSkills} result: {result3}\n");


}

static void RunAll()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++");
    Console.WriteLine("Run All()");
    Console.WriteLine("+++++++++");
    Console.WriteLine();


    var employees = Repository.LoadEmployees();

    // if all have email defined
    var result1 = employees.All(e => !string.IsNullOrWhiteSpace(e.Email));
    Console.WriteLine($"All employees have email result: {result1}\n");

    // if all employees have C#
    var result2 = employees.All(e => e.Skills.Any(s => s.Contains("C#")));
    Console.WriteLine($"All employees have c# in their skills list result: {result2}\n");

}

static void RunAllQuerySyntax()
{
    Console.WriteLine();
    Console.WriteLine("++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Run All() + Any() Query Expression");
    Console.WriteLine("++++++++++++++++++++++++++++++++++");
    Console.WriteLine();
    var employees = Repository.LoadEmployees();


    var result1 = from e in employees
                  where e.Skills.All(s => s.Contains("c", StringComparison.OrdinalIgnoreCase))
                  select e;

    result1.Print("Employees having skills  > skills");

    var result2 = from e in employees
                  where e.Skills.Any(s => s.Contains("node", StringComparison.OrdinalIgnoreCase))
                  select e;
    result2.Print("Employees having skill node");


}

static void RunContains()
{
    Console.WriteLine();
    Console.WriteLine("++++++++++++++");
    Console.WriteLine("Run Contain()");
    Console.WriteLine("++++++++++++++");
    Console.WriteLine();


    var employees = Repository.LoadEmployees();

    var e1 = employees.ToArray()[0];

    var result01 = employees.Contains(e1);

    Console.WriteLine($"find if any employee contains " +
                $"'{e1.Email}' in his/her email result: {result01}");

    var e2 = new Employee { Email = "Cole.Cochran@example.com" };
    var result02 = employees.Contains(e2);
    Console.WriteLine($"find if any employee contains " +
               $"'{e2.Email}' in his/her email result: {result02}");

}