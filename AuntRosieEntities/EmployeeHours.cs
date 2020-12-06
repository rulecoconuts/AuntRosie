using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;

namespace AuntRosieEntities
{
    public class EmployeeHours : RosieEntity
    {
        private long eventID;
        private double hours;
        private bool isPaid;
        private long employeeID;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrievePrepCmd = null;
        private static SqlCommand retrieveDateLocationPrepCmd = null;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;
        private static SqlCommand getEventsPrepCmd = null;

        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public RosieEvent RosieEvent
        {
            get => default;
            set
            {
            }
        }

        public long EventID { get => eventID; set => eventID = value; }
        public double Hours { get => hours; set => hours = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        public long EmployeeID { get => employeeID; set => employeeID = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblEmployeeHours]([EmployeeID], " +
                    "[EventID], [Hours], [isPaid]) values " +
                    "(@employee, @event, @hours, @isPaid)";


                SqlParameter employeeParam = new SqlParameter("@employee", SqlDbType.BigInt, 50);
                employeeParam.Value = EmployeeID;

                SqlParameter eventParam = new SqlParameter("@event", SqlDbType.BigInt, 0);
                eventParam.Value = EventID;

                SqlParameter hoursParam = new SqlParameter("@hours", SqlDbType.Decimal, 0);
                hoursParam.Value = Hours;

                SqlParameter paidParam = new SqlParameter("@isPaid", SqlDbType.Bit, 1);
                paidParam.Value = IsPaid;

                createPrepCmd.Parameters.Add(employeeParam);
                createPrepCmd.Parameters.Add(eventParam);
                createPrepCmd.Parameters.Add(hoursParam);
                createPrepCmd.Parameters.Add(paidParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@employee"].Value = EmployeeID;
                createPrepCmd.Parameters["@event"].Value = EventID;
                createPrepCmd.Parameters["@hours"].Value = Hours;
                createPrepCmd.Parameters["@isPaid"].Value = IsPaid;
            }

            Connector.Insert(createPrepCmd, false, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public EmployeeHours Retrieve(long employeeID, long eventID)
        {
            EmployeeHours hourRecord = null;
            if (retrievePrepCmd is null)
            {
                retrievePrepCmd = new SqlCommand(null, Connector.Connection);
                retrievePrepCmd.CommandText = "select [Hours], [isPaid] " +
                    "from [tblEmployeeHours] where [EmployeeID] = @employee and [EventID] = @event";


                SqlParameter employeeParam = new SqlParameter("@employee", SqlDbType.BigInt, 50);
                employeeParam.Value = EventID;

                SqlParameter eventParam = new SqlParameter("@event", SqlDbType.Decimal, 0);
                eventParam.Value = Hours;

                retrievePrepCmd.Parameters.Add(employeeParam);
                retrievePrepCmd.Parameters.Add(eventParam);
                retrievePrepCmd.Prepare();
            }
            else
            {
                retrievePrepCmd.Parameters["@employee"].Value = EmployeeID;
                retrievePrepCmd.Parameters["@event"].Value = EventID;
            }

            SqlDataReader reader = Connector.Retrieve(retrievePrepCmd);
            if(reader.HasRows)
            {
                hourRecord = new EmployeeHours();
                hourRecord.EventID = eventID;
                hourRecord.EmployeeID = employeeID;
                hourRecord.Hours = reader.GetDouble(0);
                hourRecord.IsPaid = reader.GetBoolean(1);
            }

            return hourRecord; 
        }
    }
}