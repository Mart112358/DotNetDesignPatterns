using System;

namespace DotNetDesignPatterns.AbstractFactory
{
    internal class OSXButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("I'm an OSXButton");
        }
    }
}