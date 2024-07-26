using Shared;

var questions = QuestionBank.All;

var questionAt10 = questions.ElementAt(10);

// var questionAt300 = questions.ElementAt(300); ArugumentOutOfRangeException
//if (questionAt300 is null)
//    Console.WriteLine("question at 300 is null");

var questionAt300 = questions.ElementAtOrDefault(300);


Console.WriteLine(questionAt300);