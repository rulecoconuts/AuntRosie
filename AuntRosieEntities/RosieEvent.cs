using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class RosieEvent : RosieEntity
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