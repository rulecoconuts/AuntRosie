using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EmployeePay : RosieEntity
    {
        private long employeeId;
        private DateTime paymentDate;
        private DateTime fromDate;
        private DateTime toDate;
        private double amount;
        private PaymentMethod paymentMethod;

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