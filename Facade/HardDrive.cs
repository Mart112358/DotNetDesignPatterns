using System;

namespace DotNetDesignPatterns.Facade
{
    internal class HardDrive
    {
        public static byte[] Read(long lba, int size)
        {
            Console.WriteLine($"HardDrive read lba : {lba}, size : {size}");
            return new byte[] {1, 2, 3};
        }
    }
}