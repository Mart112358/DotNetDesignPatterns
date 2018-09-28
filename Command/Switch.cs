using System.Collections.Generic;

namespace DotNetDesignPatterns.Command
{
    public class Switch
    {
        private readonly List<ICommand> _history;

        public Switch()
        {
            _history = new List<ICommand>();
        }

        public void StoreAndExecute(ICommand command)
        {
            // optional 
            _history.Add(command);
            command.Execute();
        }
    }
}