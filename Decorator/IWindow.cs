namespace DotNetDesignPatterns.Decorator
{
    public interface IWindow
    {
        // draws the Window
        void Draw();

        // returns a description of the Window
        string GetDescription();
    }
}