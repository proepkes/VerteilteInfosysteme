using System;
using System.Diagnostics;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace DBLib.Synchronization
{
    public class DbSynchronizer
    {
        public void Synchronize()
        {
            LogUtilities.LogTracingLevels();
            
            var clientSyncProvider = new SqlSyncProvider("FullScope", SqlConnectionFactory.DefaultClientConnection);
            clientSyncProvider.ApplyChangeFailed += ClientApplyChangeFailed;
            clientSyncProvider.ChangesSelected += ClientSyncProviderOnChangesSelected;
            
            var serverSyncProvider = new SqlSyncProvider("FullScope", SqlConnectionFactory.DefaultServerConnection);
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

            //TODO: einzelne Spalten synchronisierbar?

            // print statistics
            Console.WriteLine("Start Time: " + syncStats.SyncStartTime);
            Console.WriteLine("Total Changes Uploaded: " + syncStats.UploadChangesTotal);
                // Changes from Client to Server (LocalSyncProvider to RemoteSyncProvider)
            Console.WriteLine("Total Changes Downloaded: " + syncStats.DownloadChangesTotal);
                // Changes from Server to Client (RemoteSyncProvider to LocalSyncProvider)
            Console.WriteLine("Complete Time: " + syncStats.SyncEndTime);
            Console.WriteLine(string.Empty);
            Console.ReadLine();
        }

        private void ClientSyncProviderOnChangesSelected(object sender, DbChangesSelectedEventArgs e)
        {
            Console.WriteLine("Client Change selected: ");
            for (var i = 0; i < e.Context.DataSet.Tables.Count; i++)
            {
                var dataTable = e.Context.DataSet.Tables[i];
                for (var j = 0; j < dataTable.Rows.Count; j++)
                {
                    var row = dataTable.Rows[j];

                    Console.WriteLine(dataTable.TableName + "[" + j + "]: " + row.RowState);
                   
                }
            }
        }

        private void ServerSyncProviderOnChangesSelected(object sender, DbChangesSelectedEventArgs e)
        {
            for (var i = 0; i < e.Context.DataSet.Tables.Count; i++)
            {
                var dataTable = e.Context.DataSet.Tables[i];
                for (var j = 0; j < dataTable.Rows.Count; j++)
                {
                    var row = dataTable.Rows[j];
                    Console.WriteLine("Server Change selected: ");
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