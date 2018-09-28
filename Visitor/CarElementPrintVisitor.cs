using System;

namespace DotNetDesignPatterns.Visitor
{
    public class CarElementPrintVisitor : ICarElementVisitor
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine($"Visiting {wheel.GetName()} wheel");
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("Visiting engine");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Visiting body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Visiting car");
        }
    }
}