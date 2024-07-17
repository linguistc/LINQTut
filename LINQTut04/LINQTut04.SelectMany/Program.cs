﻿using LINQTut04.Shared;

namespace LINQTut04.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] sentences =
            {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };

            IEnumerable<string>? words = sentences.SelectMany(w => w.Split(' '));

            foreach (string word in words)
                Console.WriteLine(word);
        }

        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees();

            var skills = employees.SelectMany(e => e.Skills).Distinct();

            var result01 = (from e in employees
                           from skill in e.Skills
                           select skill).Distinct();

            foreach (var skill in result01)
                Console.WriteLine(skill);
        }
    }
}