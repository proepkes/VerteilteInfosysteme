using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace DBLib
{
    public static class SqlConnectionFactory
    {
        public static string DataSourceCe =
            @"Data Source='C:\VIDB\" + DbInfo.DefaultClientDatabase + ".mdf'";
        public static SqlConnection CreateDefaultServerConnection()
        {
            return
                new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                                  DbInfo.DefaultServerDatabase + "; Integrated Security=" + true);
        }

        public static SqlConnection CreateDefaultClientConnection()
        {
            return
                new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                                  DbInfo.DefaultClientDatabase + "; Integrated Security=" + true);
        }

        public static SqlCeConnection CreateDefaultClientCeConnection()
        {
            return
                new SqlCeConnection(DataSourceCe);
        }
    }
}