using System;

namespace DotNetDesignPatterns.Bridge
{
    public class DrawingAPI1 : IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"API1.circle at {x:f}:{y:f} radius {radius:f}");
        }
    }
}