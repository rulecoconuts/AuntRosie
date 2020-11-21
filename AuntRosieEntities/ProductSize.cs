using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class ProductSize : RosieEntity
    {
        private byte id;
        private string name;
        private string unit;
        private double value;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        public byte Id { get => id;}
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Value { get => value; set => this.value = value; }

        private void SetID(byte id)
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

        public static ProductSize Retrieve(byte id)
        {
            ProductSize ProductSize = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [SizeName], [Unit], [SizeValue] from [tblProductSize] where [SizeID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.TinyInt, 0);
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
                ProductSize = new ProductSize();
                ProductSize.SetID(id);
                ProductSize.Name = reader.GetString(0);
                ProductSize.Unit = reader.GetString(1);
                ProductSize.Value = reader.GetDouble(2);
            }

            reader.Close();

            return ProductSize;
        }

        public override string ToString()
        {
            return $"{(Name != null? ($"{Name} |"):"")} {Value} {Unit}";
        }
    }
}