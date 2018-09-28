namespace DotNetDesignPatterns.Strategy
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}