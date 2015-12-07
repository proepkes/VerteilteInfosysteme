using System.Collections.ObjectModel;
namespace DBLib
{
    public class DbTable
    {
        public DbTable(string name, string[] columns = null, bool isClientTable = true)
        {
            Name = name;
            if (columns == null) Columns = null;
            else Columns = new Collection<string>(columns);
            IsClientTable = isClientTable;
        }

        public string Name { get; private set; }

        public Collection<string> Columns { get; private set; }

        public bool IsClientTable { get; private set; }
    }
}