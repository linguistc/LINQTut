using Shared;

var q = QuestionBank.PickOne();

var q2 = new List<Question>();

for (int i = 0; i < 10; ++i)
    q2.Add(new Question());

Console.WriteLine(ReferenceEquals(q2[0], q2[1]));

var questions = Enumerable.Repeat(q, 10).ToList();

Console.WriteLine(ReferenceEquals(questions[0], questions[1]));
