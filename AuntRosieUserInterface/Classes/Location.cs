using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuntRosieUserInterface.Classes
{
    class Location
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        Location () { }

        #region CRUD Structure

        /// <summary>
        /// Creates a new product object
        /// </summary>
        /// <returns></returns>
        bool Create() { return true; }

        /// <summary>
        /// Reads an object from the database
        /// </summary>
        /// <returns></returns>
        bool Read() { return true; }

        /// <summary>
        /// Updates an object from the database
        /// </summary>
        /// <returns></returns>
        bool Update() { return true; }


        /// <summary>
        /// Deletes an object from the database
        /// </summary>
        /// <returns></returns>
        bool Delete() { return true; }

        #endregion
    }
}
