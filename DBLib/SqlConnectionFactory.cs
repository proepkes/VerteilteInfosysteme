using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace DBLib
{
    public static class SqlConnectionFactory
    {
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
                new SqlCeConnection(@"Data Source='C:\VIDB\testdb.mdf'");
        }
    }
}