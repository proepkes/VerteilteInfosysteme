using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace DBLib
{
    public static class SqlConnectionFactory
    {

        public static SqlConnection DefaultClientConnection
        {
            get
            {
                return new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                    DbInfo.DefaultClientDatabase + "; Integrated Security=" + true);
            }
        }


        public static SqlConnection DefaultServerConnection
        {
            get
            {
                return
                    new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                                      DbInfo.DefaultServerDatabase + "; Integrated Security=" + true);
            }
        }
        public static string DataSourceCe =
            @"Data Source='C:\VIDB\" + DbInfo.DefaultClientDatabase + ".mdf'";


        public static SqlCeConnection CreateDefaultClientCeConnection()
        {
            return
                new SqlCeConnection(DataSourceCe);
        }
    }
}