using LINQTut05.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut05.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();

            IOrderedEnumerable<Employee> sortedEmployees =
                employees.OrderBy(e => e);


            sortedEmployees.Print("sorted employees");

            Console.ReadKey();
        }
    }
}
