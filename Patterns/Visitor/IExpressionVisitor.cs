using System.Collections.Generic;
using System.Text;

namespace Patterns.Visitor
{
  public interface IExpressionVisitor
  {
    void Visit(LiteralExpression literal);
    void Visit(BinaryExpression expression);
  }

  public class ExpressionVisitor : IExpressionVisitor
  {
    StringBuilder sb;

    private readonly IDictionary<Operation, string> OperationValue = new Dictionary<Operation, string>()
    {
      {Operation.Addition, "+"},
      {Operation.Subtraction, "-"},
      {Operation.Division, "/"},
      {Operation.Multiplication, "*"},
    };

    public ExpressionVisitor(StringBuilder sb)
    {
      this.sb = sb;
    }

    public void Visit(LiteralExpression literal)
    {
      sb.Append(literal.Value);
    }

    public void Visit(BinaryExpression expression)
    {
      sb.Append("(");
      expression.Left.Accept(this);
      sb.Append(OperationValue[expression.Operation]);
      expression.Right.Accept(this);
      sb.Append(")");
    }
  }
}
