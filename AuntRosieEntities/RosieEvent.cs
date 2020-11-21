using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class RosieEvent : RosieEntity
    {
        private long id;
        private string name;
        private long locationId;
        private DateTime eventDate;
        private EventType type;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        public EventLocation EventLocation
        {
            get
            {
                return EventLocation.Retrieve(LocationId);
            }
            set
            {
                this.LocationId = value.Id;
            }
        }

        public IEnumerable<AuntRosieEntities.EventProduct> EventProducts
        {
            get => default;
            set
            {
            }
        }

        public long Id { get => id;}
        public string Name { get => name; set => name = value; }
        public long LocationId { get => locationId; set => locationId = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        public EventType Type { get => type; set => type = value; }

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

        /// <summary>
        /// Get a list of all events
        /// </summary>
        /// <param name="earliestDate">Earliest date</param>
        /// <returns></returns>
        public static List<RosieEvent> GetEvents(DateTime earliestDate)
        {
            List<RosieEvent> items = null;

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [EventID], [EventName], [LocationID], [EventDate], [EventType] " +
                    $"from [tblEvent] where [EventDate] >= {earliestDate.ToString()}");
            while (reader.HasRows)
            {
                reader.Read();
                RosieEvent evnt = new RosieEvent();
                evnt.SetID(reader.GetInt64(0));
                evnt.Name = reader.GetString(1);
                evnt.LocationId = reader.GetInt64(2);
                evnt.EventDate = reader.GetDateTime(3);
                evnt.Type = (EventType)reader.GetString(4)[0];

                items.Add(evnt);
            }

            reader.Close();

            return items;
        }

        public static RosieEvent Retrieve(long id)
        {
            RosieEvent reqEvent = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [EventName], [LocationID], [EventDate], [EventType] " +
                    "from [tblEvent] where [EventID] = @ID";


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
                reqEvent = new RosieEvent();
                reqEvent.SetID(id);
                reqEvent.Name = reader.GetString(0);
                reqEvent.LocationId = reader.GetInt64(1);
                reqEvent.EventDate = reader.GetDateTime(2);
                reqEvent.Type = (EventType)reader.GetString(3)[0];
            }

            reader.Close();

            return reqEvent;
        }
    }
}