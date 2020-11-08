using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class EventProduct : IRosieEntity
    {
        private long id;
        private long eventId;
        private long productionId;
        private short quantity;
    }
}