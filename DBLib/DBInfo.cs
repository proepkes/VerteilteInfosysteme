using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public class DbInfo
    {
        public static DbTable[] Tables =
        {
            new DbTable("sellers"),
            new DbTable("ship_tours"),
            new DbTable("customers"),
            new DbTable("locations"),
            new DbTable("offers"),
            new DbTable("passengers"),
            new DbTable("ship_routes"),
            new DbTable("ships"),
            new DbTable("transactions")
        };
    }
}
