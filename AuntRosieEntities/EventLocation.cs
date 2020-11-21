using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class EventLocation : RosieEntity
    {
        private long id;
        private string name;
        private Address address;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }

        public long Id { get => id;}
        public string Name { get => name; set => name = value; }

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

        public static EventLocation Retrieve(long id)
        {
            EventLocation location = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [LocationName], [LocationProvince], [LocationCity], [LocationStreet] " +
                    "from [tblEventLocation] where [LocationID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
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
                location = new EventLocation();
                location.SetID(id);
                location.Name = reader.GetString(0);
                location.Address = new Address(reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }

            reader.Close();

            return location;
        }

        public override string ToString()
        {
            return $"{(Name != null? $"{Name},": "")} {Address.ToString()}".Trim();
        }
    }
}