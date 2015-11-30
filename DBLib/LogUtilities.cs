using System;
using System.Diagnostics;
using Microsoft.Synchronization.Data;

namespace DBLib
{
    public static class LogUtilities
    {
        [Conditional("DEBUG")]
        public static void LogTracingLevels()
        {
            Console.WriteLine("** Tracing Levels Enabled for this Application **");
            Console.WriteLine("Error: " + SyncTracer.IsErrorEnabled());
            Console.WriteLine("Warning: " + SyncTracer.IsWarningEnabled());
            Console.WriteLine("Info: " + SyncTracer.IsInfoEnabled());
            Console.WriteLine("Verbose: " + SyncTracer.IsVerboseEnabled());
        }
    }
}