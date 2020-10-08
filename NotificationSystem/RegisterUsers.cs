using DPObserver;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem
{
    public class RegisterUsers : DPObserver.IObserver<DiscountInformation>
    {
        private string _email;

        public RegisterUsers(string email)
        {
            _email = email;
        }

        public void Update(DiscountInformation subject)
        {
            if (subject.State)
                Console.WriteLine($"Hello {_email}, The product {subject.ProductName} change price to {subject.Price}");
        }
    }
}
