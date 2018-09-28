using System;

namespace DotNetDesignPatterns.Composite
{
    // Leaf
    public class Ellipse : Graphic
    {
        private readonly string _name;

        public Ellipse(string name)
        {
            _name = name;
        }

        //Prints the graphic.
        public override void Print()
        {
            base.Print();
            Console.WriteLine(_name);
        }
    }
}