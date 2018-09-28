using System;

namespace DotNetDesignPatterns.Visitor
{
    public class CarElementDoVisitor : ICarElementVisitor
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine($"Kicking my {wheel.GetName()} wheel");
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("Starting my engine");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Moving my body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Starting my car");
        }
    }
}