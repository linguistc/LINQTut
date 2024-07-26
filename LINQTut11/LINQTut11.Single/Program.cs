using Shared;
using System.ComponentModel.DataAnnotations;

var questions = QuestionBank.All;
//var question = questions.Single(x => x.Title.Contains("#245"));
//var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245"));
//var question3 = questions.Single(x => x.Title.Length == 0);

var question4 = questions.SingleOrDefault(x => x.Title.Length == 0);

Console.WriteLine(question4);
