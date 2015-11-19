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
            new DbSynchronizer().Synchronize(); //Test
        }
    }
}
