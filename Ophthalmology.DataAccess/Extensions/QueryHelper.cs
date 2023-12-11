using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmology.DataAccess.Extensions
{
    internal static class QueryHelper
    {
        internal static List<T> ToListOfT<T>(this DataTable dataTable) where T : Entity.Entites.EntityBase, new()
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

        internal static List<OleDbParameter> ToOleDbParameters(this List<IFieldValue> filedValues)
        {
            var oleDbParameters = new List<OleDbParameter>();
            if (filedValues != null)
            {
                var dbParameters = filedValues.Select(filedValue => new OleDbParameter($"@{filedValue.Alias}", filedValue.Value));
                oleDbParameters.AddRange(dbParameters);
            }
            return oleDbParameters;
        }

        internal static List<OleDbParameter> ToOleDbParameters(this List<IWhereClause> filedValues)
        {
            var oleDbParameters = new List<OleDbParameter>();
            if (filedValues != null)
            {
                var dbParameters = filedValues.Select(filedValue => new OleDbParameter($"@{filedValue.Alias}", filedValue.Value));
                oleDbParameters.AddRange(dbParameters);
            }
            return oleDbParameters;
        }

        internal static string ToWhereClauseScript(this IEnumerable<IWhereClause> whereClauses)
        {
            var result = string.Empty;
            if (whereClauses == null)
                return result;

            foreach (var clause in whereClauses)
            {
                var logicalOperator = "";
                if (clause.LogicalOperator != LogicalOperatorType.None)
                    logicalOperator = clause.LogicalOperator.ToString().ToUpper();

                result = string.Join(string.Empty, result, $" {clause.FiledName} = @{clause.Alias} ", logicalOperator);
            }
            return result;
        }

        internal static Tuple<string, string> ToInsertScript(this IEnumerable<IFieldValue> filedValues)
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

        internal static string ToUpdateScript(this IEnumerable<IFieldValue> filedValues)
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
