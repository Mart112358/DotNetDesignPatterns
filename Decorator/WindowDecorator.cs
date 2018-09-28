namespace DotNetDesignPatterns.Decorator
{
    internal abstract class WindowDecorator : IWindow
    {
        // the Window being decorated
        private readonly IWindow _decoratedWindow;

        protected WindowDecorator(IWindow decoratedWindow)
        {
            _decoratedWindow = decoratedWindow;
        }

        public virtual void Draw()
        {
            //delegation
            _decoratedWindow.Draw();
        }

        public virtual string GetDescription()
        {
            //delegation
            return _decoratedWindow.GetDescription();
        }
    }
}