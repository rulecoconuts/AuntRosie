using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        protected override void Create(SqlTransaction transaction = null)
        {
            base.Create(transaction);
        }
    }
}