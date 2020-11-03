using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class RosieEvent
    {
        private int id;
        private int name;
        private int locationId;

        public EventLocation EventLocation
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<AuntRosieEntities.EventProduct> EventProducts
        {
            get => default;
            set
            {
            }
        }
    }
}