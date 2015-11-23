using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLib;
using Microsoft.Synchronization.Data.SqlServer;
using Microsoft.Synchronization.Data.SqlServerCe;

namespace ProvisionClient
{
    class ClientProvisioner
    {
        public void ProvisionClient()
        {
            // create a connection to the client database
            var clientConn = SqlConnectionFactory.CreateDefaultClientConnection();

            // create a connection to the master database
            var serverConn = SqlConnectionFactory.CreateDefaultServerConnection();

            // get the description of FullScope from the master database
            var scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope("FullScope", serverConn);

            // create provisioning object based on the FullScope
            var clientProvision = new SqlSyncScopeProvisioning(clientConn, scopeDesc);

            // starts the provisioning process
            clientProvision.Apply();
        }
    }
}
