using System;
namespace Patterns.Visitor
{
  public class Division : BinaryExpression
  {
    public Division(IExpression left, IExpression right) : base(left, Operation.Division, right) { }
  }
}
