using Observer_Design_Pattern.Enums;

namespace Observer_Design_Pattern.Interfaces
{
    public interface IObserver
    {
        void UpdateAvailability(Availability availability,string productName);
        void Subscribe(ISubject subject);
    }
}