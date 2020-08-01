using System;
using System.Diagnostics;
using System.Threading;

namespace VideoAudioExtractor
{
    static class Program
    {
        // Variables
        private static readonly string ConfigFile = System.AppDomain.CurrentDomain.BaseDirectory + "config.xml";
        private static readonly ConfigReader ConfigReader = new ConfigReader(ConfigFile);

        // Program main method
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(ConfigReader.GetIpAddress);
            }
            catch (TypeInitializationException)
            {
                Console.WriteLine("### WARNING ###");
                Console.WriteLine("config.xml not found or missing parameters!");
                StopProcess();
            }

            Worker worker = new Worker(ConfigReader.GetProcessSleepSeconds, ConfigReader);
            Thread t = new Thread(worker.RunCameraWorker) {IsBackground = true};
            t.Start();
            while (true)
            {
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.C && keyInfo.Modifiers == ConsoleModifiers.Control)
                {
                    worker.KeepGoing = false;
                    break;
                }
            }

            t.Join();
        }

        /**
         * Stop/kill self
         */
        private static void StopProcess()
        {
            Console.WriteLine("===> Quitting process...");
            Process.GetCurrentProcess().Kill();
        }
    }
}