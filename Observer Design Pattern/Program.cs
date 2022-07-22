using System;
using Observer_Design_Pattern.Components;
using Observer_Design_Pattern.Enums;
using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Subject Iphone = new Subject("Iphone", 12000, Availability.Unavailable);
            Subject Samsung = new Subject("Samsung", 10000, Availability.Unavailable);
            
            IObserver user1 = new Observer("Elon");
            user1.Subscribe(Samsung);
            
            Observer user2 = new Observer("John");
            user2.Subscribe(Samsung);
            
            Observer user3 = new Observer("Andrew");
            user3.Subscribe(Iphone);
            
            Console.WriteLine("Iphone current state : " + Iphone.Availability);
            Console.WriteLine("Samsung current state : " + Samsung.Availability);
            
            Console.WriteLine();
            Iphone.Availability = Availability.Available;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Samsung.Availability = Availability.Available;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Samsung is stock of out");
            Samsung.Availability = Availability.Unavailable;
            
            Console.Read();
            
            Console.WriteLine("Hello World!");
        }
    }
}