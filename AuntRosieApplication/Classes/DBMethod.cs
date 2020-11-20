using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AuntRosieApplication.Classes
{
    class DBMethod
    {


        /// <summary>
        /// Return connection string
        /// </summary>
        /// <returns>Connection string</returns>
        public static string GetConnectionString()
        {
            return Properties.Settings.Default.AuntRosieDBConnectionString;
        }

    }
}
