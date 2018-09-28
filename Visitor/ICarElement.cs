namespace DotNetDesignPatterns.Visitor
{
    public interface ICarElement
    {
        // CarElements have to provide accept().
        void Accept(ICarElementVisitor visitor);
    }
}