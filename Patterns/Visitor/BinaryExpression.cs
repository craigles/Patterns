namespace Patterns.Visitor
{
  public interface IExpression
  {
    void Accept(IExpressionVisitor visitor);
  }

  public class BinaryExpression : IExpression
  {
    public IExpression Left { get; set; }
    public Operation Operation { get; set; }
    public IExpression Right { get; set; }

    public BinaryExpression(IExpression left, Operation operation, IExpression right)
    {
      Left = left;
      Operation = operation;
      Right = right;
    }

    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
  }
}