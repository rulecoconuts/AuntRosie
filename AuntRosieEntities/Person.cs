using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Person : RosieEntity
    {
        private string firstName;
        private string lastName;

        protected override void Create(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        protected override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}