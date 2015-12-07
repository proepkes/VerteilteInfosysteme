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
            SqlSyncScopeProvisioning Provision = new SqlSyncScopeProvisioning(ClientCON, currentDesc);

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







    }
}
