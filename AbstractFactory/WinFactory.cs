namespace DotNetDesignPatterns.AbstractFactory
{
    internal class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }
}