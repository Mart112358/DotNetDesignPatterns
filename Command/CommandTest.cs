namespace DotNetDesignPatterns.Command
{
    public class CommandTest
    {
        public static void Test()
        {
            var light = new Light();
            var flipUpCommand = new FlipUpCommand(light);
            var flipDownCommand = new FlipDownCommand(light);

            var @switch = new Switch();
            @switch.StoreAndExecute(flipUpCommand);
            @switch.StoreAndExecute(flipDownCommand);
        }
    }
}