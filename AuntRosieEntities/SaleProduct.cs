using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class SaleProduct : RosieEntity
    {
        private long eventProductId;
        private long saleId;
        private int quantity;
        private double price;

        public Sale Sale
        {
            get => default;
            set
            {
            }
        }

        public EventProduct EventProduct
        {
            get => default;
            set
            {
            }
        }

        public override void Create(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}