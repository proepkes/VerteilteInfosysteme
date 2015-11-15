using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace DBSync
{
    class DbSynchronizer
    {
        public void Synchronize()
        {

            // create a connection to the ClientDB 
            var clientConn = new SqlConnection("Data Source=localhost; Initial Catalog=vi_client; Integrated Security=True");
            var clientSyncProvider = new SqlSyncProvider("FullScope", clientConn);
            clientSyncProvider.ApplyChangeFailed += ClientApplyChangeFailed;
            // create a connection to the ServerDB
            var serverConn = new SqlConnection("Data Source=localhost; Initial Catalog=vi_server; Integrated Security=True");
            var serverSyncProvider = new SqlSyncProvider("FullScope", serverConn);
            serverSyncProvider.ApplyChangeFailed += ServerApplyChangeFailed;
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
