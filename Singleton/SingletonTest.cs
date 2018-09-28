using System;

namespace DotNetDesignPatterns.Singleton
{
    public class SingletonTest
    {
        public static void Test()
        {
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            var hashCode1 = instance1.GetHashCode();
            var hashCode2 = instance2.GetHashCode();

            Console.WriteLine($"Hash code for instance1 : {hashCode1}");
            Console.WriteLine($"Hash code for instance2 : {hashCode2}");
        }
    }
}