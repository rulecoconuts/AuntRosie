using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class Product : RosieEntity, IDisposable
    {
        private short id;
        private string name;
        private string type;
        private string servingSize;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        public short Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string ServingSize { get => servingSize; set => servingSize = value; }

        private void SetID(short id)
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

        public static Product Retrieve(short id)
        {
            Product product = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductName], [ProductType], [ServingSize] from [tblProduct] where [ProductID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                product = new Product();
                product.SetID(id);
                product.Name = reader.GetString(0);
                product.Type = reader.GetString(1);
                product.ServingSize = reader.GetString(2);
            }

            reader.Close();

            return product;
        }

        public void Dispose()
        {
            //Dispose of prepared statements
            retrieveIdPrepCmd.Dispose();
            retrieveNamePrepCmd.Dispose();
        }
    }
}