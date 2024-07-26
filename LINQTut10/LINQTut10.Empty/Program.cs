using Shared;

var questions = new List<Question>(); // empty list

//1
//...
//1000
foreach (var q in questions)
{
    Console.WriteLine(q);
}

var questions2 = Enumerable.Empty<Question>(); // empty list

//1
//...
//1000
foreach (var q in questions2)
{
    Console.WriteLine(q);
}