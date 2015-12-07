using System.Data.SqlClient;
using Microsoft.Synchronization.Data.SqlServer;

namespace DBLib.Provisioning
{
    public class ClientProvisioner
    {
        public void ProvisionClient(SqlConnection clientConnection = null, SqlConnection serverConnection = null)
        {
            // create a connection to the client database
            var clientConn = clientConnection ?? SqlConnectionFactory.DefaultClientConnection;

            // create a connection to the master database
            var serverConn = serverConnection ?? SqlConnectionFactory.DefaultServerConnection;

            // get the description of FullScope from the master database
            var scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope("FullScope", serverConn);

            // create provisioning object based on the FullScope
            var clientProvision = new SqlSyncScopeProvisioning(clientConn, scopeDesc);

            // starts the provisioning process
            clientProvision.Apply();
        }
    }
}