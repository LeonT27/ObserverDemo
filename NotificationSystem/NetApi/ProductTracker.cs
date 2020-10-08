using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem.NetApi
{
    public class ProductTracker : IObservable<Product>
    {
        private List<IObserver<Product>> observers;
        private Product _product;

        public ProductTracker(Product product)
        {
            observers = new List<IObserver<Product>>();
            _product = product;
        }

        public IDisposable Subscribe(IObserver<Product> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Product>> _observers;
            private IObserver<Product> _observer;

            public Unsubscriber(List<IObserver<Product>> observers, IObserver<Product> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void TrackPrice(double? price)
        {
            foreach (var observer in observers)
            {
                if (!price.HasValue)
                    observer.OnError(new NullReferenceException());
                else
                {
                        _product.Price = price.Value;
                        observer.OnNext(_product);
                }
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
