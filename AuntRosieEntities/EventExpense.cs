using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EventExpense : Expense
    {
        private long eventId;
        private long expenseId;

        public RosieEvent Event
        {
            get => default;
            set
            {
            }
        }

        public Expense Expense
        {
            get => default;
            set
            {
            }
        }
    }
}