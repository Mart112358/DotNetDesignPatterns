namespace DotNetDesignPatterns.Decorator
{
    internal class VerticalScrollBarDecorator : WindowDecorator
    {
        public VerticalScrollBarDecorator(IWindow decoratedWindow)
            : base(decoratedWindow)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawVerticalScrollBar();
        }

        private static void DrawVerticalScrollBar()
        {
            // draw the vertical scrollbar
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, including vertical scrollbars";
        }
    }
}