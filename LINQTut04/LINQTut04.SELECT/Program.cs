using LINQTut04.Shared;

namespace LINQTut04.SELECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunExample01();
            // RunExample02();
            RunExample03();

            Console.ReadKey();
        }

        private static void RunExample01()
        {
            List<string> words = new() { "i", "love", "asp.net", "core" };

            IEnumerable<string> result = words.Select(w => w.ToUpper());

            //var result01 = words.Select(w => {  return w.ToUpper(); });

            // using query syntax

            var result02 = from w in words
                           select w.ToUpper();

            foreach (var w in result) 
                Console.WriteLine(w);
                    
        }

        private static void RunExample02()
        {
            List<int> numbers = new() { 1, 2, 3, 4, 5 };

            var result = numbers.Select(x => x * x);

            // query sysntax
            var result02 = from x in numbers
                           select x * x;

            foreach (var x in result)
                Console.WriteLine(x);
        }

        private static void RunExample03()
        {

            var employees = Repository.LoadEmployees();

            var result = employees.Select(e =>
            {
                return new EmployeeDto
                {
                    Name = $"{e.FirstName} {e.LastName}",
                    TotalSkills = e.Skills.Count()
                };
            });

            // using query syntax

            var result02 = from e in employees
                           select new EmployeeDto
                           {
                               Name = $"{e.FirstName} {e.LastName}",
                               TotalSkills = e.Skills.Count()
                           };

            foreach (var e in result02) 
                Console.WriteLine(e);

        }


    }
}
