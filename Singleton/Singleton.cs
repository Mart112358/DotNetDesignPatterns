namespace DotNetDesignPatterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton Instance = new Singleton();

        // Private constructor prevents instantiation from other classes
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return Instance;
        }
    }
}