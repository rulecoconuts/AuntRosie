using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

using System.ComponentModel;

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

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

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

        [Browsable(false)]
        public long Id { get => id; }
        [Browsable(false)]
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
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblProduction]([ProductItemID], [ProductionQuantity], [ExpiryDate], [ProductionDate]) " +
                    "values (@product, @qty, @expDate, @prodDate)";


                SqlParameter productItemParam = new SqlParameter("@product", SqlDbType.Int, 0);
                productItemParam.Value = ProductItemID;

                SqlParameter qtyParam = new SqlParameter("@qty", SqlDbType.SmallInt, 0);
                qtyParam.Value = Quantity;

                SqlParameter expParam = new SqlParameter("@expDate", SqlDbType.Date, 0);
                expParam.Value = ExpiryDate.Date;

                SqlParameter productionDateParam = new SqlParameter("@prodDate", SqlDbType.DateTime, 0);
                productionDateParam.Value = ProductionDate;

                createPrepCmd.Parameters.Add(productItemParam);
                createPrepCmd.Parameters.Add(qtyParam);
                createPrepCmd.Parameters.Add(expParam);
                createPrepCmd.Parameters.Add(productionDateParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@product"].Value = ProductItemID;
                createPrepCmd.Parameters["@qty"].Value = Quantity;
                createPrepCmd.Parameters["@expDate"].Value = ExpiryDate;
                createPrepCmd.Parameters["@prodDate"].Value = ProductionDate;
            }

            id = Connector.Insert(createPrepCmd, true, transaction);
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