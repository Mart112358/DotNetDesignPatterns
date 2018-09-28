using System;

namespace DotNetDesignPatterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        public void Update(Observable o, object arg)
        {
            Console.WriteLine($"Notification that something has changed in {o}");
        }
    }
}