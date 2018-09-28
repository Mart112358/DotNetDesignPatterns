using System;

namespace DotNetDesignPatterns.Composite
{
    // Component
    public abstract class Graphic
    {
        private Graphic _parent;

        public Graphic Parent
        {
            get => _parent;

            set
            {
                _parent = value;
                Level = _parent?.Level + 1 ?? 0;
            }
        }

        public virtual int Level { get; set; }

        //Prints the graphic.
        public virtual void Print()
        {
            for (var i = 0; i < Level; i++) Console.Write("\t");
        }
    }
}