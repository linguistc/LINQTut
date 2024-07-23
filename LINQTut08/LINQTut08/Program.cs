using LINQTut08.Shared;

RunGroupByExample();
RunGroupByQuerySyntax();
RunToLookupExample();

static void RunGroupByExample()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("GroupBy (Method Syntax)");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var emps = Repository.LoadEmployees();

    var result = emps.GroupBy(e => e.Department);

    foreach (var item in result)
        item.Print($"Employees in {item.Key} Department");
    
}

static void RunToLookupExample()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("ToLookup (Method Syntax)");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var emps = Repository.LoadEmployees();

    var result = emps.ToLookup(e => e.Department);

    foreach (var item in result)
        item.Print($"Employees in {item.Key} Department");

}

static void RunGroupByQuerySyntax()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("GroupBy (Query Syntax)");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var emps = Repository.LoadEmployees();

    var result = from e in emps
                 group e by e.Department into g
                 select g;

    foreach (var item in result)
        item.Print($"Employees in {item.Key} Department");

}
