using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public class DbTable
    {
        public DbTable(string name, bool isClientTable = true)
        {
            Name = name;
            IsClientTable = isClientTable;
        }

        public string Name { get; }    

        public bool IsClientTable { get; }
    }
}
