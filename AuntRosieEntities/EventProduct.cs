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