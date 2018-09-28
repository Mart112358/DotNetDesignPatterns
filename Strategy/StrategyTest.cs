using System;

namespace DotNetDesignPatterns.Strategy
{
    public class StrategyTest
    {
        public static void Test()
        {
            const int a = 3;
            const int b = 4;

            Console.WriteLine("a = " + a + ", b = " + b);
            // Three contexts following different strategies
            var context = new Context(new Add());
            var resultA = context.ExecuteStrategy(a, b);

            context = new Context(new Subtract());
            var resultB = context.ExecuteStrategy(a, b);

            context = new Context(new Multiply());
            var resultC = context.ExecuteStrategy(a, b);

            Console.WriteLine("Result A (Add): " + resultA);
            Console.WriteLine("Result B (Subtract): " + resultB);
            Console.WriteLine("Result C (Multiply): " + resultC);
        }
    }
}