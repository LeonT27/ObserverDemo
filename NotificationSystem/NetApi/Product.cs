using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem.NetApi
{
    public struct Product
    {
        private string _name;
        private double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get => _name; }
        public double Price { get => _price; set => _price = value; }
    }
}
