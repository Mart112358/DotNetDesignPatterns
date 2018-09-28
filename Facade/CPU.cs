using System;

namespace DotNetDesignPatterns.Facade
{
    internal class CPU
    {
        public static void Freeze()
        {
            Console.WriteLine("CPU: freeze");
        }

        public static void Jump(long position)
        {
            Console.WriteLine($"CPU: jump to position : {position}");
        }

        public static void Execute()
        {
            Console.WriteLine("CPU: execute");
        }
    }
}