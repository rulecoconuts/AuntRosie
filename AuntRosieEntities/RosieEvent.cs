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
        private long id = -1;
        private string name;
        private long locationId = -1;
        private DateTime eventDate;
        private EventType type;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

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
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblEvent]([EventName], [LocationID], [EventDate], [EventType]) values " +
                    "(@name, @locationID, @date, @type)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter locationParam = new SqlParameter("@locationID", SqlDbType.BigInt, 0);
                locationParam.Value = LocationId;

                SqlParameter dateParam = new SqlParameter("@date", SqlDbType.DateTime, 0);
                dateParam.Value = EventDate;

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.Char, 1);
                typeParam.Value = Type;

                createPrepCmd.Parameters.Add(nameParam);
                createPrepCmd.Parameters.Add(locationParam);
                createPrepCmd.Parameters.Add(dateParam);
                createPrepCmd.Parameters.Add(typeParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@locationID"].Value = LocationId;
                createPrepCmd.Parameters["@date"].Value = EventDate;
                createPrepCmd.Parameters["@type"].Value = Type;
            }

            id = Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblEvent] where [EventID]=@ID";


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
                updatePrepCmd.CommandText = "update [tblEvent] set [EventName] = @name, [LocationID] = @locationID," +
                    "[EventDate] = @date, [EventType] = @type where [EventID] = @ID";

                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter locationParam = new SqlParameter("@locationID", SqlDbType.BigInt, 0);
                locationParam.Value = LocationId;

                SqlParameter dateParam = new SqlParameter("@date", SqlDbType.DateTime, 0);
                dateParam.Value = EventDate;

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.Char, 1);
                typeParam.Value = Type;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(nameParam);
                updatePrepCmd.Parameters.Add(locationParam);
                updatePrepCmd.Parameters.Add(dateParam);
                updatePrepCmd.Parameters.Add(typeParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@name"].Value = Name;
                updatePrepCmd.Parameters["@locationID"].Value = LocationId;
                updatePrepCmd.Parameters["@date"].Value = EventDate;
                updatePrepCmd.Parameters["@type"].Value = Type;
            }

            Connector.Update(updatePrepCmd, transaction);
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
                retrieveIdPrepCmd.Parameters["@ID"].Value = id;
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