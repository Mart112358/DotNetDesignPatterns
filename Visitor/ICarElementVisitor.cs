namespace DotNetDesignPatterns.Visitor
{
    public interface ICarElementVisitor
    {
        void Visit(Wheel wheel);

        void Visit(Engine engine);

        void Visit(Body body);

        void Visit(Car car);
    }
}