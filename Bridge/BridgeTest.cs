namespace DotNetDesignPatterns.Bridge
{
    public class BridgeTest
    {
        public static void Test()
        {
            var shapes = new[]
            {
                new CircleShape(1, 2, 3, new DrawingAPI1()),
                new CircleShape(5, 7, 11, new DrawingAPI2())
            };

            foreach (var shape in shapes)
            {
                shape.ResizeByPercentage(2.5);
                shape.Draw();
            }
        }
    }
}