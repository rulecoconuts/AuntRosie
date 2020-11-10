﻿using System;
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

        public override void Create(SqlTransaction transaction = null)
        {
            base.Create(transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            base.Delete(transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            base.Update(transaction);
        }
    }
}