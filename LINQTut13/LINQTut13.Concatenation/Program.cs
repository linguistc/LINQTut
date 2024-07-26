using Shared;

//RunMethod01();
//RunMethod02();
RunMethod03();
RunMethod04();

static void RunMethod01()
{
    var quiz1 = QuestionBank.Randomize(3);
    var quiz2 = QuestionBank.Randomize(2);

    var quiz3 = quiz1.Concat(quiz2);
    quiz3.ToQuiz();
}

static void RunMethod02()
{
    var quiz1 = QuestionBank.Randomize(3);
    var quiz2 = QuestionBank.Randomize(2);

    var questionTitles = quiz1.Select(q => q.Title)
        .Concat(quiz2.Select(x => x.Title));

    foreach (var title in questionTitles)
        Console.WriteLine(title);
}

static void RunMethod03()
{
    var quiz1 = QuestionBank.Randomize(3);
    var quiz2 = QuestionBank.Randomize(2);

    var questionTitles =
        QuestionBank.Randomize(3).Select(q => q.Title)
        .Concat(QuestionBank.Randomize(2).Select(x => x.Title))
        .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(11, 14)).Select(y => y.Title));
    
    foreach (var title in questionTitles)
        Console.WriteLine(title);
}

static void RunMethod04()
{
    var quiz1 = QuestionBank.Randomize(3);
    var quiz2 = QuestionBank.Randomize(2);

    var quiz3 = new[] { quiz1, quiz2 }.SelectMany(quiz => quiz);

    quiz3.ToQuiz();

    
}
