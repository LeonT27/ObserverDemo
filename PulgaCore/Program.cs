using System;
using NotificationSystem;

namespace PulgaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountInformation discountInformation = new DiscountInformation("Chancleta", 20.00, true);
            discountInformation.Attach(new RegisterUsers("ltolentino@me.com"));
            discountInformation.Attach(new RegisterUsers("cruiz@me.com"));
            discountInformation.Attach(new RegisterUsers("aacosta@me.com"));

            discountInformation.Price = 40.00;
            discountInformation.Price = 25.00;
            discountInformation.Price = 30.00;
            discountInformation.Price = 35.00;

            Console.ReadLine();
        }
    }
}
