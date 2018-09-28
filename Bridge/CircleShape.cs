namespace DotNetDesignPatterns.Bridge
{
    public class CircleShape : Shape
    {
        private readonly double _x;
        private readonly double _y;
        private double _radius;

        public CircleShape(double x, double y, double radius, IDrawingAPI drawingAPI)
            : base(drawingAPI)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        // low-level i.e. Implementation specific
        public override void Draw()
        {
            _drawingAPI.DrawCircle(_x, _y, _radius);
        }

        // high-level i.e. Abstraction specific
        public override void ResizeByPercentage(double pct)
        {
            _radius *= pct;
        }
    }
}