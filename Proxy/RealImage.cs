using System;

namespace DotNetDesignPatterns.Proxy
{
    internal class RealImage : IImage
    {
        private readonly string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk();
        }

        public void DisplayImage()
        {
            Console.WriteLine($"Displaying {_filename}");
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading {_filename}");
        }
    }
}