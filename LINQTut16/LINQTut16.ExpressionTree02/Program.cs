using System.Linq.Expressions;

Expression<Func<int, bool>> IsNegativeExpression = (num) => num < 0;

ParameterExpression numParam = IsNegativeExpression.Parameters[0];
BinaryExpression operation = (BinaryExpression)IsNegativeExpression.Body;
ParameterExpression left = (ParameterExpression)operation.Left;
ConstantExpression right = (ConstantExpression)operation.Right;

Console.WriteLine($"Decomposed Expression: " +
    $"{numParam.Name} => {left.Name} {operation.NodeType} {right.Value}");
