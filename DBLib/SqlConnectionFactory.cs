﻿using System.Data.SqlClient;

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
    }
}