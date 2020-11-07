using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Expense
    {
        private long id;
        private DateTime payDate;
        private double value;
        private PaymentMethod paymentMethod;
        private string type;
        private string note;
    }
}