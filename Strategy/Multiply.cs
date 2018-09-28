using System;

namespace DotNetDesignPatterns.Strategy
{
    public class Multiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            Console.WriteLine("Called Multiply's Execute()");
            return a * b; // Do a multiplication with a and b
        }
    }
}