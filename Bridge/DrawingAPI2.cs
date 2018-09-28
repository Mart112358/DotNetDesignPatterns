using System;

namespace DotNetDesignPatterns.Bridge
{
    public class DrawingAPI2 : IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"API2.circle at {x:f}:{y:f} radius {radius:f}");
        }
    }
}