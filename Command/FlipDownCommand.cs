namespace DotNetDesignPatterns.Command
{
    public class FlipDownCommand : ICommand
    {
        private readonly Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            Light.TurnOff();
        }
    }
}