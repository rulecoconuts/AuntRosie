using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EmployeeHours : RosieEntity
    {
        private long eventID;
        private double hours;
        private bool isPaid;
        private long employeeID;

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
    }
}