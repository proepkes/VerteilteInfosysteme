using System.Data.SqlClient;
using System.Data.SqlServerCe;
using Seller_Client;

namespace DBLib
{
    public static class SqlConnectionFactory
    {

        public static SqlConnection DefaultClientConnection
        {
            get
            {
                //    return new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                //        DbInfo.DefaultClientDatabase + "; Integrated Security=" + true);
                return new SqlConnection(XMLReader.ClientConnection_String());
            }
        }


        public static SqlConnection DefaultServerConnection
        {
            get
            {
                //return
                //    new SqlConnection("Data Source=" + DbInfo.DefaultHostname + "; Initial Catalog=" +
                //                      DbInfo.DefaultServerDatabase + "; Integrated Security=" + true);
                return new SqlConnection(XMLReader.ServerConnection_String());
            }
        }
    }
}