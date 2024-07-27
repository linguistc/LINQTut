using System.Linq.Expressions;


// (num) => num % 2 == 0

ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

ConstantExpression zeroParam = Expression.Constant(0, typeof(int));
ConstantExpression twoParam = Expression.Constant(2, typeof(int));
BinaryExpression moduloBinaryExpression = Expression.Modulo(numParam, twoParam);
BinaryExpression isEvenBinaryExpression = Expression.Equal(moduloBinaryExpression, zeroParam);

Expression<Func<int, bool>> IsEvenExpression = Expression.Lambda<Func<int, bool>>(
    isEvenBinaryExpression, new ParameterExpression[] { numParam });


var isEven = IsEvenExpression.Compile();
Console.WriteLine(isEven(10));
Console.WriteLine(isEven(9));