using System;
using System.Collections.Generic;
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
    }
}