namespace DBLib
{
    public class DbTable
    {
        public DbTable(string name, bool isClientTable = true)
        {
            Name = name;
            IsClientTable = isClientTable;
        }

        public string Name { get; private set; }

        public bool IsClientTable { get; private set; }
    }
}