using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Customer : Person, IRosieEntity
    {
        private long id;
        private Address address;
        private string phone;
        private string email;

        public Address Address
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<AuntRosieEntities.Sale> Sales
        {
            get => default;
            set
            {
            }
        }
    }
}