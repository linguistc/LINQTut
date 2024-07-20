using LINQTut06.Shared;

var emps = Repository.LoadEmployees();

var q1 = emps.Skip(10);
q1.Print("Skip First 10 employees");

var q2 = emps.SkipWhile(e => e.Salary != 214400);
q2.Print("Skip while salary doesn't equal 214,400");

var q3 = emps.SkipLast(10);
q3.Print("Skip Last 10 employees");

