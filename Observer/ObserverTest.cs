using System;

namespace DotNetDesignPatterns.Observer
{
    public class ObserverTest
    {
        public static void Test()
        {
            var concreteObserver = new ConcreteObserver();
            var subject = new Subject();
            subject.AddObserver(concreteObserver);
            Console.WriteLine("Changing something to Subject.");
            subject.ChangeSomething();
        }
    }
}