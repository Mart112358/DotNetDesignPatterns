using System;

namespace DotNetDesignPatterns.Memento
{
    internal class Originator
    {
        private string _state;
        // The class could also contain additional data that is not part of the
        // state saved in the memento.

        public string State
        {
            private get => _state;
            set
            {
                Console.WriteLine($"Originator: Setting state to {value}");
                _state = value;
            }
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(State);
        }

        public static void RestoreFromMemento(Memento memento)
        {
            Console.WriteLine($"Originator: State after restoring from Memento: {memento.State}");
        }
    }
}