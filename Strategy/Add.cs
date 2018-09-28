using System;

namespace DotNetDesignPatterns.Strategy
{
    public class Add : IStrategy
    {
        public int Execute(int a, int b)
        {
            Console.WriteLine("Called Add's Execute()");
            return a + b; // Do an addition with a and b
        }
    }
}