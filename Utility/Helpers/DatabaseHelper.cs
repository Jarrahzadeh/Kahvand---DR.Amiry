using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Ophthalmology.Utility.Classes;
using Ophthalmology.Utility.Database;

namespace Ophthalmology.Utility.Helpers
{
    public static class DatabaseHelper
    {
        public static int Insert(string tableName, List<Tuple<string, Type, object>> filedNameAndValues)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            if (filedNameAndValues == null || filedNameAndValues.Count <= 0)
            {
                throw new ArgumentNullException(nameof(filedNameAndValues));
            }

            var fields = string.Empty;
            var values = string.Empty;
            var parameters = new List<OleDbParameter>();
            foreach (var filedNameAndValue in filedNameAndValues)
            {
                var separator = string.IsNullOrWhiteSpace(fields) ? string.Empty : ", ";
                fields = string.Join(separator, fields, $"{filedNameAndValue.Item1}");
                values = string.Join(separator, values, $"@{filedNameAndValue.Item1}");

                var oleDbParameter = new OleDbParameter($"@{filedNameAndValue.Item1}", filedNameAndValue.Item3);
                if (filedNameAndValue.Item2 == typeof(string))
                    oleDbParameter.DbType = DbType.String;
                else if (filedNameAndValue.Item2 == typeof(int))
                    oleDbParameter.DbType = DbType.Int32;

                parameters.Add(oleDbParameter);
            }

            var script = $" INSERT INTO {tableName} ({fields}) VALUES ({values})";

            using (var dbConnection = new DbConnection(Settings.ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.ExecuteCommand(script, parameters);
            }
        }

        public static int Update(string tableName, List<Tuple<string, Type, object>> filedNameAndValues)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            if (filedNameAndValues == null || filedNameAndValues.Count <= 0)
            {
                throw new ArgumentNullException(nameof(filedNameAndValues));
            }

            var fields = string.Empty;
            var parameters = new List<OleDbParameter>();
            foreach (var filedNameAndValue in filedNameAndValues)
            {
                var separator = string.IsNullOrWhiteSpace(fields) ? string.Empty : ", ";
                fields = string.Join(separator, fields, $"{filedNameAndValue.Item1} = @{filedNameAndValue.Item1}");

                var oleDbParameter = new OleDbParameter($"@{filedNameAndValue.Item1}", filedNameAndValue.Item3);
                if (filedNameAndValue.Item2 == typeof(string))
                    oleDbParameter.DbType = DbType.String;
                else if (filedNameAndValue.Item2 == typeof(int))
                    oleDbParameter.DbType = DbType.Int32;

                parameters.Add(oleDbParameter);
            }

            var script = $"UPDATE {tableName} SET {fields} WHERE {filedNameAndValues[0].Item1} = @{filedNameAndValues[0].Item1}";

            int rowsAffectedCount;
            using (var dbConnection = new DbConnection(Settings.ConnectionString))
            {
                dbConnection.Open();
                rowsAffectedCount = dbConnection.ExecuteCommand(script, parameters);
            }

            return rowsAffectedCount;
        }

        public static int Delete(string tableName, List<Tuple<string, Type, object, string>> whereClause = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            var script = $"DELETE FROM {tableName}";
            var parameters = new List<OleDbParameter>();

            if (whereClause != null)
            {
                var fields = GetWhereClauseScript(whereClause, parameters);
                if (!string.IsNullOrWhiteSpace(fields))
                    script += $" WHERE {fields}";
            }

            using (var dbConnection = new DbConnection(Settings.ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.ExecuteCommand(script, parameters);
            }
        }

        public static DataTable Select(string tableName, string selectFields = "*", List<Tuple<string, Type, object, string>> whereClause = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            var script = $" SELECT {selectFields} FROM {tableName}";
            var parameters = new List<OleDbParameter>();
            if (whereClause != null)
            {
                var fields = GetWhereClauseScript(whereClause, parameters);
                if (!string.IsNullOrWhiteSpace(fields))
                    script += $" WHERE {fields}";
            }

            using (var dbConnection = new DbConnection(Settings.ConnectionString))
            {
                dbConnection.Open();
                var dataTable = dbConnection.RetrieveDataTable(script, parameters);
                return dataTable;
            }
        }

        private static string GetWhereClauseScript(List<Tuple<string, Type, object, string>> whereClause, ICollection<OleDbParameter> parameters)
        {
            var fields = string.Empty;
            foreach (var tuple in whereClause)
            {
                fields = string.Join(string.Empty, fields, $" {tuple.Item1} = @{tuple.Item1} ", tuple.Item4.ToUpper());

                var oleDbParameter = new OleDbParameter($"@{tuple.Item1}", tuple.Item3);
                if (tuple.Item2 == typeof(string))
                    oleDbParameter.DbType = DbType.String;
                else if (tuple.Item2 == typeof(int))
                    oleDbParameter.DbType = DbType.Int32;

                parameters.Add(oleDbParameter);
            }

            return fields;
        }

        public static bool DatabaseIsAvailable()
        {
            try
            {
                using (var dbConnection = new DbConnection(Settings.ConnectionString))
                {
                    dbConnection.Open();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}