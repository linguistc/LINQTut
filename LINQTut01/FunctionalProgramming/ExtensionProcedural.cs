using System;


namespace FunctionalProgramming
{
    public class ExtensionProcedural
    {
        public static IEnumerable<Employee> GetEpmloyeesWithFirstNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var e in employees)
            {
                if(e.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                    yield return e;
            }
        }

        //Old Approach
        /*
           public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
           {
               var employees = Repository.LoadEmployees();

               var result = new List<Employee>();

               foreach (var employee in employees)
               {
                   if (employee.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                   {
                       result.Add(employee);
                   }
               }
               return result;
           }
        */

        public static IEnumerable<Employee> GetEpmloyeesWithFirstNameEndsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var e in employees)
            {
                if (e.FirstName.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                    yield return e;
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithLastNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var e in employees)
            {
                if (e.LastName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return e;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithDepartmentEqualsTo(string value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var e in employees)
            {
                if (e.Department.ToLowerInvariant() == value.ToLowerInvariant())
                {
                    yield return e;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesHiredInYear(int year)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.HireDate.Year == year)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesByGender(string gender)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Gender.ToLowerInvariant() == gender.ToLowerInvariant())
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithHealthInsuranceValueEqualsTo(bool value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.HasHealthInsurance == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithPensionPlanValueEqualsTo(bool value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.HasPensionPlan == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryEqualsTo(decimal value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryGreaterThan(decimal value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary > value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryLessThan(decimal value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary < value)
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
                return;

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }


    }
}
