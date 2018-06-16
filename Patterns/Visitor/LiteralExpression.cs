namespace Patterns.Visitor
{
    public class LiteralExpression : IExpression
    {
        public double Value { get; set; }

        public LiteralExpression(double value)
        {
            Value = value;
        }

    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
  }
}
