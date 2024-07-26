using Shared;

var questions = QuestionBank.All;
var firstQuestion = questions.First();
Console.WriteLine(firstQuestion);

//var someQuestion = questions.First(x => x.Title.Length == 0); //InvalidOperationException
var someOtherQuestion = questions.FirstOrDefault(x => x.Title.Length == 0); //null

if (someOtherQuestion is null)
{
    Console.WriteLine("Question is null");
}
