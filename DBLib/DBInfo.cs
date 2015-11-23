namespace DBLib
{
    public class DbInfo
    {
        public static string DefaultHostname = "localhost";
        public static string DefaultServerDatabase = "vi_server";
        public static string DefaultClientDatabase = "vi_client";

        public static DbTable[] Tables =
        {
            new DbTable("seller"),
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