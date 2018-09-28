namespace DotNetDesignPatterns.AbstractFactory
{
    public class AbstractFactoryTest
    {
        public static void Test()
        {
            var application = new Application(CreateOsSpecificFactory());
        }

        private static IGUIFactory CreateOsSpecificFactory()
        {
            var sys = ReadFromConfigFile("OS_TYPE");
            if (sys == 0)
                return new WinFactory();
            return new OSXFactory();
        }

        private static int ReadFromConfigFile(string osType)
        {
            return 1;
        }
    }
}