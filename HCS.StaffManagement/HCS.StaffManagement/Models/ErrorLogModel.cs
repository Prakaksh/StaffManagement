using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public  class ErrorLogModel
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void ErrorLog(string Controller, string Input)
        {
            // Example Logger Message Based on Bugs

            //logger.Trace("Sample trace message");
            //logger.Debug("Sample debug message");
            //logger.Info("Sample informational message");
            //logger.Warn("Sample warning message");
            //logger.Error("Sample error message");
            //logger.Fatal("Sample fatal error message");

            // alternatively you can call the Log() method
            // and pass log level as the parameter.
            logger.Log(LogLevel.Error, "Inside" + Controller + "Input" + Input);

            //MappedDiagnosticsContext.Set("Ctrl", Controller);

            //MappedDiagnosticsContext.Set("InputData", Input);
            //logger.Error("Inside " + Controller + " Controller " +  " method Input " + Input);
        }

    }
}