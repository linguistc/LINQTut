using System.Linq.Expressions;

Func<int, bool> IsEven = (num) => num % 2 == 0;
Console.WriteLine(IsEven(10));
Console.WriteLine(IsEven.Invoke(10));


Expression<Func<int, bool>> IsEvenExpression = (num) => num % 2 == 0;
Func<int, bool> IsEvenV2 = IsEvenExpression.Compile();
Console.WriteLine(IsEvenV2(10));
