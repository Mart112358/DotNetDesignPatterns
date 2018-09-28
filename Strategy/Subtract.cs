using System;

namespace DotNetDesignPatterns.Strategy
{
    public class Subtract : IStrategy
    {
        public int Execute(int a, int b)
        {
            Console.WriteLine("Called Subtract's Execute()");
            return a - b; // Do a subtraction with a and b
        }
    }
}