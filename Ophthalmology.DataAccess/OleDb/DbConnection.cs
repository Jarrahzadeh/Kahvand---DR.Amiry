using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Ophthalmology.DataAccess.OleDb
{
    public class DbConnection : IDisposable
    {
        #region ~( Fields )~

        private readonly OleDbConnection _oleDbConnection;

        #endregion

        #region ~( Constructors )~

        public DbConnection(string connectionString)
        {
            _oleDbConnection = new OleDbConnection(connectionString);
        }

        #endregion

        #region ~( Methods )~

        public void Dispose()
        {
            Close();
            _oleDbConnection.Dispose();
        }

        public void Open()
        {
            _oleDbConnection.Open();
        }

        public void Close()
        {
            _oleDbConnection.Close();
        }

        public int ExecuteNonQuery(string script, List<OleDbParameter> parameters)
        {
            using (var command = _oleDbConnection.CreateCommand())
            {
                command.CommandText = script;
                command.CommandType = CommandType.Text;
                command.Parameters.AddRange(parameters.ToArray());
                return command.ExecuteNonQuery();
            }
        }

        public T ExecuteScalar<T>(string script, List<OleDbParameter> parameters)
        {
            using (var command = _oleDbConnection.CreateCommand())
            {
                command.CommandText = script;
                command.CommandType = CommandType.Text;
                command.Parameters.AddRange(parameters.ToArray());
                var scalar = command.ExecuteScalar();
                return (T)Convert.ChangeType(scalar, typeof(T));
            }
        }

        public DataTable RetrieveDataTable(string script, List<OleDbParameter> parameters)
        {
            var dataTable = new DataTable();
            using (var oleDbCommand = _oleDbConnection.CreateCommand())
            {
                oleDbCommand.CommandText = script;
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.Parameters.AddRange(parameters.ToArray());
                using (var oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand))
                {
                    oleDbDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        #endregion
    }
}