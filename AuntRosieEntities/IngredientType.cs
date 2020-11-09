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

        /// <summary>
        /// Prepared statement to retrieve ingredient by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve ingredient by name
        /// </summary>
        private static SqlCommand retrieveNamePrepCmd = null;

        public short Id { get => id;}
        public string Name { get => name; set => name = value; }

        private void SetID(short id)
        {
            this.id = id;
        }

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
            IngredientType type = null;
            bool newPrep = false;

            //Prepare statement
            if (retrieveNamePrepCmd is null)
            {
                newPrep = true;
                retrieveNamePrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveNamePrepCmd.CommandText = "select [InventoryTypeId] from [tblInventoryType]  where [TypeName] = @name";
            }

            SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
            nameParam.Value = name;

            if (newPrep)
            {
                retrieveNamePrepCmd.Prepare();
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveNamePrepCmd);
            if (reader.HasRows)
            {
                type = new IngredientType();
                type.SetID(reader.GetInt16(0));
                type.Name = name;
            }

            return type;
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IngredientType Retrieve(short id)
        {
            IngredientType type = null;
            bool newPrep = false;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                newPrep = true;
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [TypeName] from [tblInventoryType]  where [InventoryTypeID] = @ID";
            }

            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
            idParam.Value = id;

            if (newPrep)
            {
                retrieveIdPrepCmd.Prepare();
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if(reader.HasRows)
            {
                type = new IngredientType();
                type.SetID(id);
                type.Name = reader.GetString(0);
            }


            return type;
        }
    }
}