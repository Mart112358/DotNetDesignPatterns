using System;

namespace DotNetDesignPatterns.Command
{
    public class Light
    {
        public static void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public static void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}