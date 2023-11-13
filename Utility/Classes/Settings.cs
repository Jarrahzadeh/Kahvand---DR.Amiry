using System;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.Utility.Classes
{
    public class Settings
    {
        private const string ConstDatabaseName = "DatabaseName";
        private const string ConstDataSourcePath = "DataSourcePath";
        private const string ConstConnectionString = "Main";

        public static string DatabaseName
        {
            get
            {
                return ConfigurationHelper.GetValue(ConstDatabaseName);
            }
        }

        public static string DataSourcePath
        {
            get
            {
                return ConfigurationHelper.GetValue(ConstDataSourcePath);
            }
        }

        public static string ConnectionString
        {
            get
            {
                var con = ConfigurationHelper.GetConnectionString(ConstConnectionString);
                con = string.Format(con, DataSourcePath, DatabaseName);
                return con;
            }
        }
        
        /// <summary>
        /// بدست آوردن موقعیت نقطه اعشار
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public static int DecimalPlace(decimal argument)
        {
            var bits = decimal.GetBits(argument);
            var bytes = BitConverter.GetBytes(bits[3]);
            int count = bytes[2];
            return count;
        }

        /// <summary>
        /// حذف اعداد بعد از اعشار تا 3 رقم
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal GetDecimalNumberWith3DecimalPlace(decimal value)
        {
            return Math.Truncate(value * 1000m) / 1000m;
        }
    }
}
