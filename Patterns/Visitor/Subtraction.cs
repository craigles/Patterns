using System;
namespace Patterns.Visitor
{
  public class Subtraction : BinaryExpression
  {
    public Subtraction(IExpression left, IExpression right) : base(left, Operation.Subtraction, right) { }
  }
}
