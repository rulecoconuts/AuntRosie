using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class EventProduct : RosieEntity
    {
        private long id;
        private long eventId;
        private long productionId;
        private short quantity;

        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public long Id { get => id; set => id = value; }
        public long EventId { get => eventId; set => eventId = value; }
        public long ProductionId { get => productionId; set => productionId = value; }
        public short Quantity { get => quantity; set => quantity = value; }

        private void SetID(long id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblEventProduct]([EventID], [ProductionID], [Quantity]) values " +
                    "(@event, @production, @quantity)";


                SqlParameter eventParam = new SqlParameter("@event", SqlDbType.BigInt, 0);
                eventParam.Value = EventId;

                SqlParameter productionParam = new SqlParameter("@production", SqlDbType.BigInt, 0);
                productionParam.Value = ProductionId;

                SqlParameter quantityParam = new SqlParameter("@quantity", SqlDbType.SmallInt, 0);
                quantityParam.Value = Quantity;

                createPrepCmd.Parameters.Add(eventParam);
                createPrepCmd.Parameters.Add(productionParam);
                createPrepCmd.Parameters.Add(quantityParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@event"].Value = EventId;
                createPrepCmd.Parameters["@production"].Value = ProductionId;
                createPrepCmd.Parameters["@quantity"].Value = Quantity;
            }

            id = Connector.Insert(createPrepCmd, true, transaction);
        }



        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblEventProduct] where [EventProductID]=@ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                deletePrepCmd.Parameters.Add(idParam);

                deletePrepCmd.Prepare();
            }
            else
            {
                deletePrepCmd.Parameters["@ID"].Value = Id;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblEventProduct] set [EventID]=@event, [ProductionID]=@production, " +
                    "[Quantity]=@quantity where [EventProductID]=@ID";

                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                SqlParameter eventParam = new SqlParameter("@event", SqlDbType.BigInt, 0);
                eventParam.Value = EventId;

                SqlParameter productionParam = new SqlParameter("@production", SqlDbType.BigInt ,0);
                productionParam.Value = ProductionId;

                SqlParameter quantityParam = new SqlParameter("@quantity", SqlDbType.SmallInt, 0);
                quantityParam.Value = Quantity;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(eventParam);
                updatePrepCmd.Parameters.Add(productionParam);
                updatePrepCmd.Parameters.Add(quantityParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@event"].Value = EventId;
                updatePrepCmd.Parameters["@production"].Value = ProductionId;
                updatePrepCmd.Parameters["@quantity"].Value = Quantity;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        public static EventProduct Retrieve(short id)
        {
            EventProduct product = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [EventID], [ProductionID], [Quantity] from [tblEventProduct] " +
                    "where [EventProductID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Parameters.Add(idParam);

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
                product = new EventProduct();
                product.SetID(id);
                product.EventId = reader.GetInt64(0);
                product.ProductionId = reader.GetInt64(1);
                product.Quantity = reader.GetInt16(2);
            }

            reader.Close();

            return product;
        }
    }
}