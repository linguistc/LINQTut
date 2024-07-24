﻿
using LINQTut09.Shared;
using System.ComponentModel.DataAnnotations;

//RunJoin();
//RunJoinQuerySyntax();

RunGroupJoin();
RunGroupJoinQuerySyntax();

void RunJoin()
{
    var emps = Repository.LoadEmployees();
    var deps = Repository.LoadDepartment();

    var query = emps.Join(deps, e => e.DepartmentId,
        d => d.Id,
        (e, d) => new
        {
            e.FullName,
            d.Name
        });

    foreach (var item in query)
        Console.WriteLine($"{item.FullName} [{item.Name}]");
}

void RunJoinQuerySyntax()
{
    var emps = Repository.LoadEmployees();
    var deps = Repository.LoadDepartment();

    var query = from e in emps
                join d in deps
                on e.DepartmentId equals d.Id
                select new {e.FullName, d.Name};


    foreach (var item in query)
        Console.WriteLine($"{item.FullName} [{item.Name}]");
}

void RunGroupJoin()
{
    var emps = Repository.LoadEmployees();
    var deps = Repository.LoadDepartment();

    var query = deps.GroupJoin(emps, d => d.Id, e => e.DepartmentId,
        (d, e) => new
        {
            Department = d.Name,
            Employees = e
        });

    foreach (var group in query)
    {
        Console.WriteLine();
        Console.WriteLine($"++++++++++++++++++++++ {group.Department} +++++++++++++++++++");
        Console.WriteLine();

        foreach (var item in group.Employees)
        {
            Console.WriteLine($"{item.FullName}");
        }

    }

}

void RunGroupJoinQuerySyntax()
{
    var emps = Repository.LoadEmployees();
    var deps = Repository.LoadDepartment();

    var query = from d in deps
                join e in emps
                on d.Id equals e.DepartmentId
                into empGroup
                select empGroup;

    foreach (var group in query)
    {
        Console.WriteLine();
        Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();

        foreach (var item in group)
        {
            Console.WriteLine($"{item.FullName}");
        }

    }
}