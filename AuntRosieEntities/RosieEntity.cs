using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AuntRosieEntities
{
    public abstract class RosieEntity
    {
        protected static DBConnector connector;

        protected abstract void Create(SqlTransaction transaction = null);
        protected abstract void Delete(SqlTransaction transaction = null);
        protected abstract void Update(SqlTransaction transaction = null);
    }
}