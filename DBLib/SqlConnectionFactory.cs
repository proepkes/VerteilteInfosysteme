using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public static class SqlConnectionFactory
    {
        public static SqlConnection CreateConnection(string hostname, string databasename, bool integratedSecurity = true)
        {
            return new SqlConnection("Data Source=" + hostname + "; Initial Catalog=" + databasename + "; Integrated Security=" + integratedSecurity);
        }

        public static SqlConnection CreateDefaultServerConnection()
        {
            return CreateConnection(DbInfo.DefaultHostname, DbInfo.DefaultServerDatabase);
        }

        public static SqlConnection CreateDefaultClientConnection()
        {
            return CreateConnection(DbInfo.DefaultHostname, DbInfo.DefaultClientDatabase);
        }
    }
}
