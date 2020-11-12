using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Production : RosieEntity
    {
        private long id;
        private int productItemID;
        private DateTime productionDate;
        private short quantity;
        private DateTime expiryDate;

        public ProductItem ProductItem
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