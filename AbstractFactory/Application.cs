namespace DotNetDesignPatterns.AbstractFactory
{
    public class Application
    {
        public Application(IGUIFactory factory)
        {
            var button = factory.CreateButton();
            button.Paint();
        }
    }
}