using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class IngredientType : RosieEntity
    { 
        private short id = -1;
        private string name = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public short Id { get => id;}
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Create a new type of ingredient
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            bool newPrep = false;
            if(createPrepCmd is null)
            {
                newPrep = true;
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblIngredientType]([TypeName]) values (@name)";
            }

            SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
            nameParam.Value = Name;

            createPrepCmd.Parameters.Add(nameParam);

            if(newPrep)
            {
                createPrepCmd.Prepare();
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }

        /// <summary>
        /// Delete ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Delete(SqlTransaction transaction = null)
        {
            bool newPrep = false;
            if (deletePrepCmd is null)
            {
                newPrep = true;
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblIngredientType] where [IngredientTypeID] = @ID";
            }

            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
            idParam.Value = Id;

            deletePrepCmd.Parameters.Add(idParam);

            if (newPrep)
            {
                deletePrepCmd.Prepare();
            }

            Connector.Delete(deletePrepCmd, transaction);
        }

        /// <summary>
        /// Update ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Update(SqlTransaction transaction = null)
        {
            bool newPrep = false;
            if (updatePrepCmd is null)
            {
                newPrep = true;
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblInventoryType] set [TypeName] = @name where [InventoryTypeID] = @ID";
            }

            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
            idParam.Value = Id;

            SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
            nameParam.Value = Name;


            updatePrepCmd.Parameters.Add(idParam);
            updatePrepCmd.Parameters.Add(nameParam);

            if (newPrep)
            {
                updatePrepCmd.Prepare();
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by name
        /// </summary>
        /// <param name="name">Name of the ingredient to retrieve</param>
        /// <returns></returns>
        public static IngredientType Retrieve(string name)
        {
            return null;
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IngredientType Retrieve(short id)
        {
            return null;
        }
    }
}