using System;

namespace DotNetDesignPatterns.Adapter
{
    public class Employee : IEmployee
    {
        private readonly string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public void ShowHappiness()
        {
            Console.WriteLine($"Employee {_name} showed happiness");
        }
    }
}