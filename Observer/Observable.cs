using System.Collections.Generic;

namespace DotNetDesignPatterns.Observer
{
    public abstract class Observable
    {
        private readonly List<IObserver> _observers;
        private bool _hasChanged;

        protected Observable()
        {
            _observers = new List<IObserver>();
        }

        protected void SetChanged()
        {
            _hasChanged = true;
        }

        protected void NotifyObservers()
        {
            NotifyObservers(null);
        }

        private void NotifyObservers(object arg)
        {
            if (!_hasChanged) return;
            foreach (var observer in _observers)
                observer.Update(this, arg);
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}