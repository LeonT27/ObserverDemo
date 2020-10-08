using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver
{
    public abstract class Subject<T>
    {
        private List<IObserver<T>> _observers = new List<IObserver<T>>();

        public void Attach(IObserver<T> observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver<T> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(T obj)
        {
            foreach (IObserver<T> o in _observers)
            {
                o.Update(obj);
            }
        }
    }
}
