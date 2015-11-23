using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.Server;
using Microsoft.Synchronization.Data.SqlServer;
using DBLib;

namespace DBSync
{
    class DbSynchronizer
    {
        public void Synchronize()
        {
            LogUtilities.LogTracingLevels();

            // create a connection to the ClientDB 
            var clientConn = SqlConnectionFactory.CreateDefaultClientConnection();
            var clientSyncProvider = new SqlSyncProvider("FullScope", clientConn);
            clientSyncProvider.ApplyChangeFailed += ClientApplyChangeFailed;
            clientSyncProvider.ChangesSelected += ClientSyncProvider_ChangesSelected;

            // create a connection to the ServerDB
            var serverConn = SqlConnectionFactory.CreateDefaultServerConnection();
            var serverSyncProvider = new SqlSyncProvider("FullScope", serverConn);
            serverSyncProvider.ApplyChangeFailed += ServerApplyChangeFailed;
            serverSyncProvider.ChangesSelected += ServerSyncProviderOnChangesSelected;
            // create the sync orhcestrator
            var syncOrchestrator = new SyncOrchestrator
            {   
                LocalProvider = clientSyncProvider,
                RemoteProvider = serverSyncProvider,
                Direction = SyncDirectionOrder.UploadAndDownload
                
            };
            // execute the synchronization process
            var syncStats = syncOrchestrator.Synchronize();

            // print statistics
            Console.WriteLine("Start Time: " + syncStats.SyncStartTime);
            Console.WriteLine("Total Changes Uploaded: " + syncStats.UploadChangesTotal); // Changes from Client to Server (LocalSyncProvider to RemoteSyncProvider)
            Console.WriteLine("Total Changes Downloaded: " + syncStats.DownloadChangesTotal); // Changes from Server to Client (RemoteSyncProvider to LocalSyncProvider)
            Console.WriteLine("Complete Time: " + syncStats.SyncEndTime);
            Console.WriteLine(string.Empty);
            Console.ReadLine();
        }

        private void ClientSyncProvider_ChangesSelected(object sender, DbChangesSelectedEventArgs e)
        {
            for (int i = 0; i < e.Context.DataSet.Tables.Count; i++)
            {
                var dataTable = e.Context.DataSet.Tables[i];
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    var row = dataTable.Rows[j];
                    if (row.RowState == DataRowState.Modified)
                    {
                        Console.WriteLine("Change selected: ");
                        Console.WriteLine("-Table: " + dataTable.TableName);
                        Console.WriteLine("-Row: " + j);
                    }
                }
            }
        }

        private void ServerSyncProviderOnChangesSelected(object sender, DbChangesSelectedEventArgs e)
        {
            for (int i = 0; i < e.Context.DataSet.Tables.Count; i++)
            {
                var dataTable = e.Context.DataSet.Tables[i];
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    var row = dataTable.Rows[j];
                        Console.WriteLine("Change selected: ");
                        Console.WriteLine("-Table: " + dataTable.TableName);
                        Console.WriteLine("-Row " + row.ItemArray[0] + ": " + row.RowState);
                    
                }
            }
        }

        private void ServerApplyChangeFailed(object sender, DbApplyChangeFailedEventArgs e)
        {
            PrintChangeFailedEventArgs(sender, e);
        }

        private void ClientApplyChangeFailed(object sender, DbApplyChangeFailedEventArgs e)
        {
            PrintChangeFailedEventArgs(sender, e);
        }

        [Conditional("DEBUG")]
        private void PrintChangeFailedEventArgs(object sender, DbApplyChangeFailedEventArgs e)
        {
            // display conflict type
            Console.WriteLine(e.Conflict.Type);

            // display error message 
            Console.WriteLine(e.Error);
        }
    }
}
