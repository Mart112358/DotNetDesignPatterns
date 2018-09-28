using System;

namespace DotNetDesignPatterns.Decorator
{
    public class DecoratorTest
    {
        public static void Test()
        {
            IWindow window = new SimpleWindow();
            Console.WriteLine(window.GetDescription());

            window = new HorizontalScrollBarDecorator(window);
            Console.WriteLine(window.GetDescription());

            window = new VerticalScrollBarDecorator(window);
            Console.WriteLine(window.GetDescription());
        }
    }
}