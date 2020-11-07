using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Employee : Person
    {
        private long id;
        private EmployeeType type;
        private string role;
        private Address address;
        private string email;
        private string phone;

        public Address Address
        {
            get => default;
            set
            {
            }
        }
    }
}