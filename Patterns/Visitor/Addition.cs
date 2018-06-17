namespace Patterns.Visitor
{
  public class Addition : BinaryExpression
  {
    public Addition(IExpression left, IExpression right) : base(left, Operation.Addition, right) {}
  }
}
