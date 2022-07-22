using System.Collections.Generic;
using Observer_Design_Pattern.Enums;
using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern.Components
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

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
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.UpdateAvailability(_availability,ProductName);
            }
        }
    }
}