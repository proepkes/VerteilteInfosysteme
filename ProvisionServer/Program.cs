using System.Data.SqlClient;
using DBLib;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace VIDBReplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection serverConn = new SqlConnection("Data Source=localhost; Initial Catalog=vi_server; Integrated Security=True");
            
            //var deprovisionScope = new SqlSyncScopeDeprovisioning(serverConn);
            //deprovisionScope.DeprovisionScope("FullScope");
            
            // define a new scope
            DbSyncScopeDescription scopeDesc = new DbSyncScopeDescription("FullScope");

            // add the table description to the sync scope definition
            foreach (var table in DBInfo.Tables)
                scopeDesc.Tables.Add(SqlSyncDescriptionBuilder.GetDescriptionForTable(table, serverConn));
            

            // create a server scope provisioning object based on the ProductScope
            SqlSyncScopeProvisioning serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

            // skipping the creation of table since table already exists on server
            serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);

            // start the provisioning process
            if(!serverProvision.ScopeExists(scopeDesc.ScopeName))
                serverProvision.Apply();
        }
    }
}
