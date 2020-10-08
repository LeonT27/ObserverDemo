using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem.NetApi
{
    public class RegisterUsers : IObserver<Product>
    {
        private IDisposable unsubscriber;
        private string _email;

        public RegisterUsers(string email)
        {
            _email = email;
        }

        public virtual void Subscribe(IObservable<Product> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"The Location Tracker has completed transmitting data to {_email}.");
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{_email}: The location cannot be determined.");
        }

        public void OnNext(Product value)
        {
            Console.WriteLine($"Hello {_email}, The product {value.Name} change price to {value.Price}");
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
