using System.Collections.Generic;

namespace DotNetDesignPatterns.Memento
{
    public class MementoTest
    {
        // Client is the caretaker
        public static void Test()
        {
            var savedStates = new List<Memento>();
            var originator = new Originator {State = "State1"};
            originator.State = "State2";
            savedStates.Add(originator.SaveToMemento());
            originator.State = "State3";
            // We can request multiple mementos, and choose which one to roll back to.
            savedStates.Add(originator.SaveToMemento());
            originator.State = "State4";
            Originator.RestoreFromMemento(savedStates[1]);
        }
    }
}