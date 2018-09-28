namespace DotNetDesignPatterns.Visitor
{
    public static class VisitorTest
    {
        public static void Test()
        {
            var car = new Car();
            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());
        }
    }
}