using System;
using System.Text;
using Patterns.Visitor;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new BinaryExpression(
              new BinaryExpression(
                new LiteralExpression(3), Operation.Addition, new LiteralExpression(4)),
                Operation.Subtraction, 
                new LiteralExpression(2));
      
            var sb = new StringBuilder();
            var printer = new ExpressionVisitor(sb);
            e.Accept(printer);

            Console.WriteLine(sb);
        }
    }
}
