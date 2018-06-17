using System;
namespace Patterns.Visitor
{
	public class Multiplication : BinaryExpression
  {
    public Multiplication(IExpression left, IExpression right) : base(left, Operation.Multiplication, right) { }
    }
}
