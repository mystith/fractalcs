using System;
using Serilog;
using Serilog.Core;

namespace fractalcs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create logging level switch to allow for logger level to be changed to what is inside config, after logger initialization
            LoggingLevelSwitch lls = new LoggingLevelSwitch();
            
            //Initialize logger
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(lls)
                .WriteTo.Console()
                .WriteTo.File("logs/logfile.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}
