using DPObserver;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem
{
    public class DiscountInformation : Subject<DiscountInformation>
    {
        private string _productName;
        private double _price;
        private bool _state;

        public string ProductName { get => _productName; }
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify(this);
                }
            }
        }
        public bool State { get => _state; }

        public DiscountInformation(string productName, double price, bool state)
        {
            _productName = productName;
            _price = price;
            _state = state;
        }
    }
}
