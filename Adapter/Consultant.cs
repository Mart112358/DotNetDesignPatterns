using System;

namespace DotNetDesignPatterns.Adapter
{
    public class Consultant
    {
        private readonly string _name;

        protected Consultant(string name)
        {
            _name = name;
        }

        protected void ShowSmile()
        {
            Console.WriteLine($"Consultant {_name} showed smile");
        }
    }
}