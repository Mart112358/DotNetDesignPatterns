namespace DotNetDesignPatterns.Decorator
{
    internal class HorizontalScrollBarDecorator : WindowDecorator
    {
        public HorizontalScrollBarDecorator(IWindow decoratedWindow)
            : base(decoratedWindow)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawHorizontalScrollBar();
        }

        private static void DrawHorizontalScrollBar()
        {
            // draw the horizontal scrollbar
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, including horizontal scrollbars";
        }
    }
}