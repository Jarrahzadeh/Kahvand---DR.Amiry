using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Enums;
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

        private static List<T> ToListOfT<T>(this DataTable dataTable) where T : Entity.Entites.EntityBase, new()
        {
            var result = new List<T>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                var item = new T();
                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    var propertyInfo = item.GetType().GetProperties().FirstOrDefault(p => p.Name.ToLower() == dataColumn.ColumnName.ToLower());
                    if (propertyInfo == null)
                        continue;

                    var value = dataRow[dataColumn];
                    if (value is DBNull)
                    {
                        value = null;
                    }

                    propertyInfo.SetValue(item, value);
                }

                result.Add(item);
            }

            return result;
        }

        private static List<OleDbParameter> ToOleDbParameters(this List<IFieldValue> filedValues)
        {
            var oleDbParameters = new List<OleDbParameter>();
            if (filedValues != null)
            {
                var dbParameters = filedValues.Select(filedValue => new OleDbParameter($"@{filedValue.Alias}", filedValue.Value));
                oleDbParameters.AddRange(dbParameters);
            }
            return oleDbParameters;
        }

        private static List<OleDbParameter> ToOleDbParameters(this List<IWhereClause> filedValues)
        {
            var oleDbParameters = new List<OleDbParameter>();
            if (filedValues != null)
            {
                var dbParameters = filedValues.Select(filedValue => new OleDbParameter($"@{filedValue.Alias}", filedValue.Value));
                oleDbParameters.AddRange(dbParameters);
            }
            return oleDbParameters;
        }

        private static string ToWhereClauseScript(this IEnumerable<IWhereClause> whereClauses)
        {
            var result = string.Empty;
            foreach (var clause in whereClauses)
            {
                var logicalOperator = "";
                if (clause.LogicalOperator != LogicalOperatorType.None)
                    logicalOperator = clause.LogicalOperator.ToString().ToUpper();

                result = string.Join(string.Empty, result, $" {clause.FiledName} = @{clause.Alias} ", logicalOperator);
            }
            return result;
        }

        private static Tuple<string, string> ToInsertScript(this IEnumerable<IFieldValue> filedValues)
        {
            var fields = string.Empty;
            var values = string.Empty;

            foreach (var filedValue in filedValues)
            {
                var separator = string.IsNullOrWhiteSpace(fields) ? string.Empty : ", ";
                fields = string.Join(separator, fields, $"{filedValue.Alias}");
                values = string.Join(separator, values, $"@{filedValue.Alias}");
            }

            return new Tuple<string, string>(fields, values);
        }

        private static string ToUpdateScript(this IEnumerable<IFieldValue> filedValues)
        {
            var script = string.Empty;
            foreach (var filedValue in filedValues)
            {
                var separator = string.IsNullOrWhiteSpace(script) ? string.Empty : ", ";
                script = string.Join(separator, script, $"{filedValue.Alias} = @{filedValue.Alias}");
            }
            return script;
        }
    }
}