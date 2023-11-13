using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Ophthalmology.Utility.Database
{
    public class DbConnection : IDisposable
    {
        private readonly OleDbConnection _oleDbConnection;

        public DbConnection(string connectionString)
        {
            _oleDbConnection = new OleDbConnection(connectionString);
        }

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

        public int ExecuteCommand(string script, List<OleDbParameter> parameters)
        {
            using (var command = _oleDbConnection.CreateCommand())
            {
                command.CommandText = script;
                command.CommandType = CommandType.Text;
                command.Parameters.AddRange(parameters.ToArray());
                return command.ExecuteNonQuery();
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
    }
}