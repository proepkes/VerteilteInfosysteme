using System;
using System.Data.SqlClient;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace DBSync
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a connection to the ClientDB 
            var clientConn = new SqlConnection("Data Source=localhost; Initial Catalog=vi_client; Integrated Security=True");
            var clientSyncProvider = new SqlSyncProvider("FullScope", clientConn);
            clientSyncProvider.ApplyChangeFailed += ApplyChangeFailed;
            // create a connection to the ServerDB
            var serverConn = new SqlConnection("Data Source=localhost; Initial Catalog=vi_server; Integrated Security=True");
            var serverSyncProvider = new SqlSyncProvider("FullScope", serverConn);
            serverSyncProvider.ApplyChangeFailed += ApplyChangeFailed;
            // create the sync orhcestrator
            var syncOrchestrator = new SyncOrchestrator
            {
                LocalProvider = clientSyncProvider,
                RemoteProvider = serverSyncProvider,
                Direction = SyncDirectionOrder.UploadAndDownload
            };

            // execute the synchronization process test
            var syncStats = syncOrchestrator.Synchronize();
            
            // print statistics
            Console.WriteLine("Start Time: " + syncStats.SyncStartTime);
            Console.WriteLine("Total Changes Uploaded: " + syncStats.UploadChangesTotal); // Changes from Client to Server
            Console.WriteLine("Total Changes Downloaded: " + syncStats.DownloadChangesTotal); // Changes from Server to Client
            Console.WriteLine("Complete Time: " + syncStats.SyncEndTime);
            Console.WriteLine(string.Empty);
            Console.ReadLine();
        }

        static void ApplyChangeFailed(object sender, DbApplyChangeFailedEventArgs e)
        {
            // display conflict type
            Console.WriteLine("Konflikttyp: " + e.Conflict.Type);

            // display error message 
            Console.WriteLine(e.Error);
        }
    }
}
