using System;

namespace DotNetDesignPatterns.AbstractFactory
{
    internal class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("I'm a WinButton");
        }
    }
}