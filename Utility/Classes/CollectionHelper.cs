using System;
using System.Data;
using System.Linq;

namespace Ophthalmology.Utility.Classes
{
    public static class CollectionHelper
    {
        public static Array ConvertToList(this DataTable dataTable, string columnName)
        {
            var result = dataTable
                .Rows
                .Cast<DataRow>()
                .Select(dr => dr[columnName].ToString())
                .ToArray();

            return result;
        }
    }
}