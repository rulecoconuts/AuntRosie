using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace AuntRosieEntities
{
    public class DBConnector
    {
        private SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public DBConnector(string connectionString)
        {
            this.Connect(connectionString);
        }

        /// <summary>
        /// Connect to a database
        /// </summary>
        /// <param name="connectionString">DB connection string</param>
        public void Connect(string connectionString)
        {
            if(!(Connection is null))
            {
                Connection.Close();
            }
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        /// <summary>
        /// Disconnect from a database
        /// </summary>
        public void Disconnect()
        {
            if(!(Connection is null))
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="getInsertedID">If true return the primary key of the newly inserted record else; return if insertion was successful</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>The last inserted id</returns>
        /// 

        public long Insert(string query, bool getInsertedID = true, SqlTransaction transaction = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            long result = -1;

            if (transaction is null)
            {
                adapter.InsertCommand = new SqlCommand(query, Connection);
            }
            else
            {
                adapter.InsertCommand = new SqlCommand(query, Connection, transaction);
            }

            result = getInsertedID? Convert.ToInt64(adapter.InsertCommand.ExecuteScalar()) : adapter.InsertCommand.ExecuteNonQuery();

            adapter.InsertCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>Number of affected records</returns>
        public long Update(string query, SqlTransaction transaction = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            long result = -1;

            if (transaction is null)
            {
                adapter.UpdateCommand = new SqlCommand(query, Connection);
            }
            else
            {
                adapter.UpdateCommand = new SqlCommand(query, Connection, transaction);
            }

            result = adapter.UpdateCommand.ExecuteNonQuery();

            adapter.UpdateCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        /// <summary>
        /// Delete a record from the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public long Delete(string query, SqlTransaction transaction = null)
        {
            return Delete(new SqlCommand(query, Connection), transaction);
        }

        /// <summary>
        /// Delete a record from the database
        /// </summary>
        /// <param name="command">Sqlcommand to execute</param>
        /// <param name="transaction">Transaction to execute the operation in</param>
        /// <returns></returns>
        public long Delete(SqlCommand command, SqlTransaction transaction = null)
        {
            long result = -1;

            SqlDataAdapter adapter = new SqlDataAdapter();

            if(!(transaction is null))
            {
                command.Transaction = transaction;
            }

            adapter.DeleteCommand = command;

            result = adapter.DeleteCommand.ExecuteNonQuery();

            adapter.DeleteCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        public SqlDataReader Retrieve(string query, SqlTransaction transaction = null)
        {
            throw new System.NotImplementedException();
        }
    }
}