using System;
using System.Text;
using Patterns.Visitor;

namespace Patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      var e = new Addition(new Multiplication(
          new LiteralExpression(3), new LiteralExpression(4)),
          new LiteralExpression(2));

      var sb = new StringBuilder();
      var printer = new ExpressionVisitor(sb);
      e.Accept(printer);

      Console.WriteLine(sb);
    }
  }
}
