namespace DotNetDesignPatterns.Facade
{
    public class FacadeTest
    {
        public static void Test()
        {
            var computer = new Computer();
            Computer.Start();
        }
    }
}