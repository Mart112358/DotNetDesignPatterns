namespace DotNetDesignPatterns.AbstractFactory
{
    internal class OSXFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new OSXButton();
        }
    }
}