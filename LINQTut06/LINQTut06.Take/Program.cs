using LINQTut06.Shared;

var emps = Repository.LoadEmployees();

var q1 = emps.Take(10);
q1.Print("Skip First 10 employees");

var q2 = q1.TakeWhile(e => e.Salary != 214_400);
q2.Print("Skip while salary doesn't equal 214,400");

var q3 = emps.TakeLast(10);
q3.Print("Take Last 10 employees");
