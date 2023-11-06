namespace Utility.Classes
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
    }
}
