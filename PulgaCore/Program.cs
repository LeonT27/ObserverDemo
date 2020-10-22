using System;
using NotificationSystem;
using NotificationSystem.NetApi;

namespace PulgaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountInformation discountInformation = new DiscountInformation("Chancleta", 20.00, true);
            discountInformation.Attach(new NotificationSystem.RegisterUsers("ltolentino@me.com"));
            discountInformation.Attach(new NotificationSystem.RegisterUsers("cruiz@me.com"));
            discountInformation.Attach(new NotificationSystem.RegisterUsers("aacosta@me.com"));

            discountInformation.Price = 40.00;
            discountInformation.Price = 25.00;
            discountInformation.Price = 30.00;
            discountInformation.Price = 35.00;

            //NetApi
            ProductTracker tracker = new ProductTracker(new Product("Chancleta Net", 20.00));
            NotificationSystem.NetApi.RegisterUsers users1 = new NotificationSystem.NetApi.RegisterUsers("aaa@me.com");
            users1.Subscribe(tracker);
            NotificationSystem.NetApi.RegisterUsers users2 = new NotificationSystem.NetApi.RegisterUsers("bbb@me.com");
            users2.Subscribe(tracker);

            tracker.TrackPrice(40.00);
            tracker.TrackPrice(25.00);
            tracker.TrackPrice(null);
            tracker.EndTransmission();
            Console.ReadLine();
        }
    }
}
