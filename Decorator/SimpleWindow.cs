namespace DotNetDesignPatterns.Decorator
{
    internal class SimpleWindow : IWindow
    {
        public void Draw()
        {
            // draw window
        }

        public string GetDescription()
        {
            return "simple window";
        }
    }
}