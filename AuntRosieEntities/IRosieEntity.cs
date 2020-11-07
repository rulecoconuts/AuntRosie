using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AuntRosieEntities
{
    public interface IRosieEntity
    {
        void Create(SqlTransaction transaction = null);
        void Delete(SqlTransaction transaction = null);
        void Update(SqlTransaction transaction = null);
    }
}