using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topshelf.ConsoleApp
{
    internal class Service
    {
        public class LoggingService : ServiceControl
        {
            private const string _logFileLocation = @"D:\Projects\.netCore\servicelog.txt";

            private void Log(string logMessage)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_logFileLocation));
                File.AppendAllText(_logFileLocation, DateTime.UtcNow.ToString() + " : " + logMessage + Environment.NewLine);
            }

            public bool Start(HostControl hostControl)
            {
                Log("Starting");
                return true;
            }

            public bool Stop(HostControl hostControl)
            {
                Log("Stopping");
                return true;
            }
        }
    }
}
