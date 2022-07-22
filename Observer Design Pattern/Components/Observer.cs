using System;
using Observer_Design_Pattern.Enums;
using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern.Components
{
    public class Observer : IObserver
    {
        public string UserName { get; private set; }

        public Observer(string userName)
        {
            UserName = userName;
        }

        public void UpdateAvailability(Availability availability,string productName)
        {
            Console.WriteLine($"Hi {UserName},the Product [{productName}] is now {availability} on Amazon");
        }

        public void Subscribe(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
    }
}