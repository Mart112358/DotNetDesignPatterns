namespace DotNetDesignPatterns.Visitor
{
    public class Body : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}