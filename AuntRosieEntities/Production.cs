using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class Production : RosieEntity
    {
        private long id;
        private int productItemID;
        private DateTime productionDate;
        private short quantity;
        private DateTime expiryDate;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        public ProductItem ProductItem
        {
            get
            {
                return ProductItem.Retrieve(ProductItemID);
            }
            set
            {
                ProductItemID = value.Id;
                Update();
            }
        }

        public long Id { get => id; }
        public int ProductItemID { get => productItemID; set => productItemID = value; }
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public short Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }

        private void SetID(long id)
        {
            this.id = id;
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

        public static Production Retrieve(long id)
        {
            Production production = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductItemID], [ProductionDate], [ProductionQuantity], [ExpiryDate]" +
                    " from [tblProduction] where [ProductionID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["@ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                production = new Production();
                production.SetID(id);
                production.ProductItemID = reader.GetInt16(0);
                production.ProductionDate = reader.GetDateTime(1);
                production.Quantity = reader.GetInt16(2);
                production.ExpiryDate = reader.GetDateTime(3);
            }

            reader.Close();

            return production;
        }
    }
}