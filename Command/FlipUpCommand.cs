namespace DotNetDesignPatterns.Command
{
    public class FlipUpCommand : ICommand
    {
        private readonly Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            Light.TurnOn();
        }
    }
}