using System;
using System.Data.SqlServerCe;
using DBLib;

namespace ProvisionClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //SqlCeEngine engine =
            // new SqlCeEngine(SqlConnectionFactory.DataSourceCe);
            //if (false == engine.Verify())
            //{
            //    Console.WriteLine("Database is corrupted.");
            //    try
            //    {
            //        engine.Repair(null, RepairOption.DeleteCorruptedRows);
            //    }
            //    catch (SqlCeException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //Console.WriteLine("Press any key to continue.");
            //Console.ReadLine();
            new ClientProvisioner().ProvisionClient();
        }
    }
}