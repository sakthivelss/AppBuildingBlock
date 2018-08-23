using System;
using NLog;

namespace logger
{
    class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
               // SystemC.Alliance.Logging.Azure.
                Logger.Info("Application started...");

                //  run your code here
            }
            catch (Exception e)
            {
                Logger.Fatal(e, "An unexpected exception has occured");
            }
            finally
            {
                Logger.Info("Application terminated. Press <enter> to exit...");
                Console.ReadLine();
                LogManager.Flush();
            }


        }
    }
}
