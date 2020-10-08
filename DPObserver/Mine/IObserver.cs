using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver
{
    public interface IObserver<T>
    {
        void Update(T subject);
    }
}
