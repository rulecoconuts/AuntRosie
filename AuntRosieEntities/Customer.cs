using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Customer : Person
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