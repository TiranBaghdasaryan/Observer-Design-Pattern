namespace Observer_Design_Pattern.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
        
    }
}