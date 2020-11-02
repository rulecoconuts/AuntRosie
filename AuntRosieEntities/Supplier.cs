using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Supplier
    {
        private int id;
        private string name;
        private string phone;
        private Person contact;
        private Address address;

        public Person Contact
        {
            get => default;
            set
            {
            }
        }
    }
}