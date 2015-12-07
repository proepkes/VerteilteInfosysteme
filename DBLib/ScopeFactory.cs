using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DBLib
{
    public class ScopeFactory
    {
        
        SqlConnection ServerCON,ClientCON;
        
        public ScopeFactory(SqlConnection ServerCon, SqlConnection ClientCon)
        {
            ServerCON = ServerCon;
            ClientCON = ClientCon;
        }



        public void refreshServerScope(int SellerID)
        {
            //define Scope
            DbSyncScopeDescription currentDesc = new DbSyncScopeDescription(DbInfo.ScopeName(SellerID));
            //add the tables to the scope discription (defined in DBTable)
            foreach (DbTable table in DbInfo.Tables)
                currentDesc.Tables.Add(SqlSyncDescriptionBuilder.GetDescriptionForTable(table.Name,table.Columns, ServerCON));

            

            // create a server scope provisioning object
            SqlSyncScopeProvisioning Provision = new SqlSyncScopeProvisioning(ServerCON, currentDesc);

            // so use the Skip parameter
            Provision.SetCreateTableDefault(DbSyncCreationOption.Skip);

            // set the filter column on the Orders table to OriginState
            Provision.Tables["sellers"].AddFilterColumn("ID");

            // set the filter value to NC
            Provision.Tables["sellers"].FilterClause = "[side].[ID] != 2";

            //Provision.Tables["sellers"].ObjectSchema

            refreshScope(Provision,currentDesc, ServerCON);

            if (!Provision.ScopeExists(currentDesc.ScopeName))
                Provision.Apply();
        }

        public void refreshClientScope(int SellerID)
        {
            DbSyncScopeDescription currentDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(DbInfo.ScopeName(SellerID), ServerCON);
            // create a server scope provisioning object
            var Provision = new SqlSyncScopeProvisioning(ClientCON, currentDesc);

            refreshScope(Provision,currentDesc, ClientCON);

            if (!Provision.ScopeExists(currentDesc.ScopeName))
                Provision.Apply();

            // unstimmigkeiten zwischen scope und realer db (col add/remove /alter type)


        }

 



        private void refreshScope(SqlSyncScopeProvisioning Provision, DbSyncScopeDescription currentDesc, SqlConnection CON)
        {
            // start the provisioning process
            if (Provision.ScopeExists(currentDesc.ScopeName))
            {
                DbSyncScopeDescription dbDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(currentDesc.ScopeName, CON);

                MessageBox.Show(currentDesc.Tables[0].Columns[1].QuotedName + ": " + currentDesc.Tables[0].Columns[1].Type + " <" + currentDesc.Tables[0].Columns[1].Size + ">\n" +
                    dbDesc.Tables[0].Columns[1].QuotedName + ": " + dbDesc.Tables[0].Columns[1].Type + " <" + dbDesc.Tables[0].Columns[1].Size + ">"
                    );

                if (!compareDescriptions(currentDesc, dbDesc) || true)                 
                {
                    if (MessageBox.Show("The Scope '" + currentDesc.ScopeName + "' is out of sync with the Database!\nShould the Scope be rewritten?\nWarning:\nAll Scope-Data (Trigger etc.) will be lost!",
                        "Warning,   Scope is invalid!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        SqlSyncScopeDeprovisioning DeProvision = new SqlSyncScopeDeprovisioning(CON);
                        DeProvision.DeprovisionScope(currentDesc.ScopeName);

                    }
                }
            }


        }


        public bool compareDescriptions(DbSyncScopeDescription desc1, DbSyncScopeDescription desc2)
        {
            bool res;
            if (desc1.Tables.Count != desc2.Tables.Count) return false;
            DbSyncTableDescription table2;
            foreach (DbSyncTableDescription table1 in desc1.Tables)
            {
                res = false;
                for (int j = 0; j < desc2.Tables.Count; j++)
                {
                    if (desc2.Tables[j].LocalName == table1.LocalName)
                    {
                        res = true;
                        table2 = desc2.Tables[j];
                        if (table1.LocalName != table2.LocalName) return false;
                        if (table1.Columns.Count != table2.Columns.Count) return false;
                        for (int i = 0; i < table1.Columns.Count; i++)
                        {
                            if (table1.Columns[i].QuotedName != table2.Columns[i].QuotedName) return false;
                            if (table1.Columns[i].Size != table2.Columns[i].Size) return false;
                            if (table1.Columns[i].Type != table2.Columns[i].Type) return false;
                            if (table1.Columns[i].IsNullable != table2.Columns[i].IsNullable) return false;
                            if (table1.Columns[i].IsPrimaryKey != table2.Columns[i].IsPrimaryKey) return false;
                        }

                    }
                }
                if (!res) return false;
            }
            


            return true;
        }


        public void ReProvision(SqlConnection conn, string scopeName)
        {
            var serverConfig = new SqlSyncScopeProvisioning();
            var scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(scopeName, conn);
            scopeDesc.ScopeName += "_temp";
            string tableName;
            foreach (DbTable table in DbInfo.Tables)
            {
                tableName = table.Name;
                DropTrackingForTable(conn, tableName);

                var bracketedName = string.Format("[{0}]", tableName);
                scopeDesc.Tables.Remove(scopeDesc.Tables[bracketedName]);

                var tableDescription = SqlSyncDescriptionBuilder.GetDescriptionForTable(bracketedName, conn);
                scopeDesc.Tables.Add(tableDescription);
            }

            serverConfig.PopulateFromScopeDescription(scopeDesc);
            serverConfig.SetCreateProceduresDefault(DbSyncCreationOption.Skip);
            serverConfig.SetCreateTableDefault(DbSyncCreationOption.Skip);
            serverConfig.SetCreateTrackingTableDefault(DbSyncCreationOption.Skip);
            serverConfig.SetCreateTriggersDefault(DbSyncCreationOption.Skip);
            serverConfig.SetPopulateTrackingTableDefault(DbSyncCreationOption.Skip);
            serverConfig.SetCreateProceduresForAdditionalScopeDefault(DbSyncCreationOption.Skip);

            foreach (DbTable table in DbInfo.Tables)
            {
                tableName = table.Name;
                var bracketedName = string.Format("[{0}]", tableName);

                serverConfig.Tables[bracketedName].CreateProcedures = DbSyncCreationOption.Create;
                serverConfig.Tables[bracketedName].CreateTrackingTable = DbSyncCreationOption.Create;
                serverConfig.Tables[bracketedName].PopulateTrackingTable = DbSyncCreationOption.Create;
                serverConfig.Tables[bracketedName].CreateTriggers = DbSyncCreationOption.Create;
            }
            serverConfig.Apply(conn);

            using (SqlCommand comm1 = new SqlCommand(@"  
         declare @config_id uniqueidentifier, @config_data xml  
         SELECT @config_id=sc.config_id, @config_data=sc.config_data  
         From scope_config sc Join [scope_info] si on si.scope_config_id=sc.config_id  
         WHERE si.sync_scope_name = @scope_name + '_temp'  
   
         Update [scope_config] Set config_data=@config_data  
         From scope_config sc Join [scope_info] si on si.scope_config_id=sc.config_id  
         WHERE si.sync_scope_name = @scope_name  
   
         Delete [scope_config] WHERE config_id=@config_id;  
         Delete [scope_info] WHERE scope_config_id=@config_id;  
       ", conn))
            {
                //conn.Open();
                comm1.Parameters.AddWithValue("@scope_name", scopeName);
                comm1.ExecuteNonQuery();
                //conn.Close();
            }
        }  



public void DropTrackingForTable(SqlConnection conn ,string tableName)
      {
        SqlCommand comm;
        StringBuilder sb = new StringBuilder();
        //Drop tracking table & triggers
        sb.AppendFormat(@"
                IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}_tracking]') AND type in (N'U'))
                DROP TABLE [dbo].[{0}_tracking]
                IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[{0}_insert_trigger]'))
                DROP TRIGGER [dbo].[{0}_insert_trigger]
                IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[{0}_delete_trigger]'))
                DROP TRIGGER [dbo].[{0}_delete_trigger]
                IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[{0}_update_trigger]'))
                DROP TRIGGER [dbo].[{0}_update_trigger]
                ",tableName);
        //Drop Procedures
        foreach (string procName in new string[] { "delete", "deletemetadata", "insert", "insertmetadata", "update", "updatemetadata", "selectrow", "selectchanges" })
        {
          sb.AppendFormat(@"
                  IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}_{1}]') AND type in (N'P', N'PC'))
                  DROP PROCEDURE [dbo].[{0}_{1}]
                  ", tableName, procName);
        }
        using (comm = new SqlCommand(sb.ToString(), conn))
        {
          //conn.Open();
          comm.ExecuteNonQuery();
          //conn.Close();
        }
      }






    }
}
