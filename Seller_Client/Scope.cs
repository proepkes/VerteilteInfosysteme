using System.Data.SqlClient;
using DBLib;

namespace Seller_Client
{
    class Scope
    {
        SqlConnection server, client;
        ScopeFactory scopeFactory;
        
        public Scope(SqlConnection Server, SqlConnection Client)
        {
            server = Server;
            client = Client;
            scopeFactory = new ScopeFactory(server,client);
        }

        public void Init_Scopes()
        {
            scopeFactory.refreshClientScope(XMLReader.SellerID());
        }
    }
}
