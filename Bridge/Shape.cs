namespace DotNetDesignPatterns.Bridge
{
    public abstract class Shape
    {
        protected IDrawingAPI _drawingAPI;

        protected Shape(IDrawingAPI drawingAPI)
        {
            _drawingAPI = drawingAPI;
        }

        // low-level
        public abstract void Draw();

        // high-level
        public abstract void ResizeByPercentage(double pct);
    }
}