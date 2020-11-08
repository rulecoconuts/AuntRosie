using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Sale : IRosieEntity
    {
        private long id;
        private long customerId;
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