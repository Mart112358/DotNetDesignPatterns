namespace DotNetDesignPatterns.Observer
{
    public class Subject : Observable
    {
        public void ChangeSomething()
        {
            SetChanged();
            NotifyObservers();
        }

        public override string ToString()
        {
            return "Subject";
        }
    }
}