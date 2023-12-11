using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Ophthalmology.DataAccess.Extensions;
using Ophthalmology.Entity.Database;
using Ophthalmology.Utility.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.DataAccess.OleDb
{
    public static class DatabaseHelper
    {
        public static int Insert(string tableName, List<IFieldValue> filedNameAndValues)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            if (filedNameAndValues == null || filedNameAndValues.Count <= 0)
            {
                throw new ArgumentNullException(nameof(filedNameAndValues));
            }

            var insertScript = filedNameAndValues.ToInsertScript();
            var script = $" INSERT INTO {tableName} ({insertScript.Item1}) VALUES ({insertScript.Item2})";

            try
            {
                var parameters = filedNameAndValues.ToOleDbParameters();
                using (var dbConnection = new DbConnection(Config.ConnectionString))
                {
                    dbConnection.Open();
                    return dbConnection.ExecuteNonQuery(script, parameters);
                }
            }
            catch (Exception e)
            {
                e.Log();
                return -1;
            }
        }

        public static int Update(string tableName, List<IFieldValue> filedNameAndValues, List<IWhereClause> whereClauses = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            if (filedNameAndValues == null || filedNameAndValues.Count <= 0)
            {
                throw new ArgumentNullException(nameof(filedNameAndValues));
            }

            var fields = filedNameAndValues.ToUpdateScript();
            var whereClauseScript = whereClauses.ToWhereClauseScript();

            var script = $"UPDATE {tableName} SET {fields} WHERE {whereClauseScript}";

            int rowsAffectedCount;
            try
            {
                var parameters = filedNameAndValues.ToOleDbParameters();
                parameters.AddRange(whereClauses.ToOleDbParameters());

                using (var dbConnection = new DbConnection(Config.ConnectionString))
                {
                    dbConnection.Open();
                    rowsAffectedCount = dbConnection.ExecuteNonQuery(script, parameters);
                }
            }
            catch (Exception e)
            {
                e.Log();
                rowsAffectedCount = -1;
            }

            return rowsAffectedCount;
        }

        public static int Delete(string tableName, List<IWhereClause> whereClauses = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            var script = $"DELETE FROM {tableName}";
            var parameters = new List<OleDbParameter>();

            if (whereClauses != null)
            {
                parameters = whereClauses.ToOleDbParameters();
                var fields = whereClauses.ToWhereClauseScript();
                if (!string.IsNullOrWhiteSpace(fields))
                    script += $" WHERE {fields}";
            }

            try
            {
                using (var dbConnection = new DbConnection(Config.ConnectionString))
                {
                    dbConnection.Open();
                    return dbConnection.ExecuteNonQuery(script, parameters);
                }
            }
            catch (Exception e)
            {
                e.Log();
                return -1;
            }
        }

        public static List<T> Select<T>(string tableName = "", string selectFields = "*", List<IWhereClause> whereClauses = default, string sortOrder = default)
            where T : Entity.Entites.EntityBase, new()
        {
            if (string.IsNullOrEmpty(tableName))
                tableName = new T().TableName;

            var dataTable = Select(tableName, selectFields, whereClauses, sortOrder);
            var result = dataTable.ToListOfT<T>();
            return result;
        }

        public static DataTable Select(string tableName, string selectFields = "*", List<IWhereClause> whereClauses = default, string sortOrder = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            var script = $"SELECT {selectFields} FROM {tableName}";
            var parameters = new List<OleDbParameter>();
            if (whereClauses != null)
            {
                parameters = whereClauses.ToOleDbParameters();
                var fields = whereClauses.ToWhereClauseScript();
                if (!string.IsNullOrWhiteSpace(fields))
                    script += $" WHERE{fields}";
            }

            if (!string.IsNullOrWhiteSpace(sortOrder))
                script += $"ORDER BY {sortOrder}";

            return SelectCore(script, parameters);
        }

        public static DataTable SelectRawQuery(string script)
        {
            return SelectCore(script, new List<OleDbParameter>());
        }

        public static bool TableHasRecord(string tableName, List<IWhereClause> whereClauses = default)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            var script = $"SELECT COUNT(*) FROM {tableName}";
            var parameters = new List<OleDbParameter>();
            if (whereClauses != null)
            {
                parameters = whereClauses.ToOleDbParameters();
                var fields = whereClauses.ToWhereClauseScript();
                if (!string.IsNullOrWhiteSpace(fields))
                    script += $" WHERE{fields}";
            }

            using (var dbConnection = new DbConnection(Config.ConnectionString))
            {
                dbConnection.Open();
                var rows = dbConnection.ExecuteScalar<int>(script, parameters);
                return rows > 0;
            }
        }

        public static bool DatabaseIsAvailable()
        {
            try
            {
                using (var dbConnection = new DbConnection(Config.ConnectionString))
                {
                    dbConnection.Open();
                }

                return true;
            }
            catch (Exception e)
            {
                e.Log();
                return false;
            }
        }

        private static DataTable SelectCore(string script, List<OleDbParameter> parameters)
        {
            try
            {
                using (var dbConnection = new DbConnection(Config.ConnectionString))
                {
                    dbConnection.Open();
                    var dataTable = dbConnection.RetrieveDataTable(script, parameters);
                    return dataTable;
                }
            }
            catch (Exception e)
            {
                e.Log();
                return new DataTable();
            }
        }
    }
}