using System.Data.SqlClient;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace DBLib.Provisioning
{
    public class ServerProvisioner
    {
        public void ProvisionServer(SqlConnection serverConnection = null)
        {
            var serverConn = serverConnection ?? SqlConnectionFactory.DefaultServerConnection;

            var deprovisionScope = new SqlSyncScopeDeprovisioning(serverConn);
            deprovisionScope.DeprovisionScope("FullScope");

            // define a new scope
            var scopeDesc = new DbSyncScopeDescription("FullScope");

            // add the table description to the sync scope definition
            foreach (var table in DbInfo.Tables) //TODO: view (oder JOINs) synchronisieren?
                scopeDesc.Tables.Add(SqlSyncDescriptionBuilder.GetDescriptionForTable(table.Name, serverConn));
            
            //TODO: Server-Event feuern sobald ein Client synchronisiert

            // create a server scope provisioning object based on the ProductScope
            var serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

            // skipping the creation of table since table already exists on server
            serverProvision.SetCreateTableDefault(DbSyncCreationOption.CreateOrUseExisting);

            // start the provisioning process
            if (!serverProvision.ScopeExists(scopeDesc.ScopeName))
                serverProvision.Apply();
        }
    }
}