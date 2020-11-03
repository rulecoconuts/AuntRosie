using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Customer : Person
    {
        private int id;
        private int address;
        private int phone;

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