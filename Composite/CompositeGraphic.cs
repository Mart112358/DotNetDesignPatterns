using System;
using System.Collections.Generic;

namespace DotNetDesignPatterns.Composite
{
    internal class CompositeGraphic : Graphic
    {
        //Collection of child graphics.
        private readonly List<Graphic> _childGraphics;
        private readonly string _name;

        public CompositeGraphic(string name)
        {
            _name = name;
            _childGraphics = new List<Graphic>();
        }


        public override int Level
        {
            get => base.Level;
            set
            {
                base.Level = value;

                foreach (var graphic in _childGraphics) graphic.Level++;
            }
        }

        //Prints the graphic.
        public override void Print()
        {
            base.Print();
            Console.WriteLine(_name);
            foreach (var graphic in _childGraphics) graphic.Print();
        }

        //Adds the graphic to the composition.
        public void Add(Graphic graphic)
        {
            graphic.Parent = this;
            _childGraphics.Add(graphic);
        }

        //Removes the graphic from the composition.
        public void Remove(Graphic graphic)
        {
            _childGraphics.Remove(graphic);
        }
    }
}