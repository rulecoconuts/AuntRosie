using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EventExpense : Expense
    {
        private int eventId;

        public RosieEvent Event
        {
            get => default;
            set
            {
            }
        }
    }
}