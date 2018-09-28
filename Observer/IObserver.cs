namespace DotNetDesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(Observable o, object arg);
    }
}