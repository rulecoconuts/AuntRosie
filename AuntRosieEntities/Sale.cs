using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Sale
    {
        private int id;
        private int customerId;
        private DateTime date;
        private PaymentMethod paymentMethod;

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }
    }
}