using DBLib;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;
using System;
namespace VIDBReplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serverConn = SqlConnectionFactory.CreateDefaultServerConnection();

            //var deprovisionScope = new SqlSyncScopeDeprovisioning(serverConn);
            //deprovisionScope.DeprovisionScope("FullScope");

            // define a new scope
            var scopeDesc = new DbSyncScopeDescription("FullScope");

            // add the table description to the sync scope definition
            foreach (var table in DbInfo.Tables)
                scopeDesc.Tables.Add(SqlSyncDescriptionBuilder.GetDescriptionForTable(table.Name, serverConn));

            //TODO: Protokollierung von Aenderungen // Aenderungen ausgeben
            //TODO: Server-Event feuern sobald ein Client synchronisiert

            // create a server scope provisioning object based on the ProductScope
            var serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

            // skipping the creation of table since table already exists on server
            serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);

            // start the provisioning process
            if (!serverProvision.ScopeExists(scopeDesc.ScopeName))
                serverProvision.Apply();

            Console.Write("fontionne bien (y)");
        }
    }
}
