using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut04.Shared
{
    public static class ExtensionFunctional
    {
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate)
        {
            foreach (Employee e in source)
            {
                if(predicate(e))
                    yield return e;
            }
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);

            }
        }
    }
}
