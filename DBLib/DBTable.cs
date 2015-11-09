using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public class DbTable
    {
        public DbTable(string name)
        {
            Name = name;
        }
        public string Name { get; }    
    }
}
