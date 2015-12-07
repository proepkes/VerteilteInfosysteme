
using System.Collections.ObjectModel;
namespace DBLib
{
    public class DbInfo
    {
        public static string ScopeName(int SellerID) { return "ClientScope_" + SellerID; }

        public static DbTable[] Tables =
        {
            new DbTable("sellers", new string[]{"ID","forename","surname","efficiency"}),
            new DbTable("ship_tours"),
            new DbTable("ship_routes"),
            new DbTable("customers"),
            new DbTable("locations"),
            new DbTable("offers"),
            new DbTable("passengers"),
            new DbTable("ships"),
            new DbTable("transactions")
        };
    }
}