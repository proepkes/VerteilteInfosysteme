using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization.Data;

namespace DBLib
{
    public static class LogUtilities
    {
        [Conditional("DEBUG")]
        public static void LogTracingLevels()
        {
            Console.WriteLine("** Tracing Levels Enabled for this Application **");
            Console.WriteLine("Error: " + SyncTracer.IsErrorEnabled().ToString());
            Console.WriteLine("Warning: " + SyncTracer.IsWarningEnabled().ToString());
            Console.WriteLine("Info: " + SyncTracer.IsInfoEnabled().ToString());
            Console.WriteLine("Verbose: " + SyncTracer.IsVerboseEnabled().ToString());
        }
    }
}
