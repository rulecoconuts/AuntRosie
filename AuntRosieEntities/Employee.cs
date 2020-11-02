using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Employee : Person
    {
        private int id;
        private int firstName;
        private int lastName;
        private int type;
        private int role;
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