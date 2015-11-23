namespace DBSync
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new DbSynchronizer().Synchronize();
        }
    }
}