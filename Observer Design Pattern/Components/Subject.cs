using System;
using Observer_Design_Pattern.Enums;
using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern.Components
{
    public class Subject : ISubject
    {
        event Action<Availability,string> onAvailabilityChanged;
        public Subject(string productName, int productPrice, Availability availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string ProductName { get; private set; }
        public int ProductPrice { get; private set; }
        private Availability _availability;

        public Availability Availability
        {
            get => _availability;
            set
            {
                _availability = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            onAvailabilityChanged -= observer.UpdateAvailability;
            onAvailabilityChanged += observer.UpdateAvailability;
        }

        public void RemoveObserver(IObserver observer)
        {
            onAvailabilityChanged -= observer.UpdateAvailability;
        }

        public void NotifyObservers()
        {
            // foreach (var observer in _observers)
            // {
            //     observer.UpdateAvailability(_availability,ProductName);
            // }
            
            onAvailabilityChanged?.Invoke(_availability,ProductName);
        }
    }
}