using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class RosieEvent : IRosieEntity
    {
        private long id;
        private string name;
        private long locationId;
        private DateTime EventDate;
        private EventType type;

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