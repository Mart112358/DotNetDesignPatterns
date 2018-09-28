using System;

namespace DotNetDesignPatterns.Facade
{
    internal class Memory
    {
        public static void Load(long position, byte[] data)
        {
            Console.WriteLine($"Memory: load position: {position}, data: {data}");
        }
    }
}