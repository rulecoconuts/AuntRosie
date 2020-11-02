using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EventLocation
    {
        private int id;
        private int name;
        private Address address;

        public Address Address
        {
            get => default;
            set
            {
            }
        }
    }
}