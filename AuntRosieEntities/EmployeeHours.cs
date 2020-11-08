using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EmployeeHours : IRosieEntity
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
    }
}