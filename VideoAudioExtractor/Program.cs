using System;
using System.Threading;

namespace VideoAudioExtractor
{
    static class Program
    {
        private static readonly string configFile =
            "C:\\Users\\Martin\\Documents\\RiderProjects\\hikvision-video-audio-extractor\\config.xml";

        private static readonly ConfigReader ConfigReader = new ConfigReader(configFile);
        private static NVRConnector _nvrConnector = null;

        static void Main(string[] args)
        {
            _nvrConnector = new NVRConnector(
                ConfigReader.GetIpAddress,
                ConfigReader.GetPort,
                ConfigReader.GetUserName,
                ConfigReader.GetPassword
            );

            Worker worker = new Worker(ConfigReader.GetProcessSleepSeconds);
            Thread t = new Thread(worker.DoWork) {IsBackground = true};
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
    }


    class Worker
    {
        public bool KeepGoing { get; set; }
        private readonly int _processSleepSeconds;

        public Worker(int processSleepSeconds)
        {
            _processSleepSeconds = processSleepSeconds;
            KeepGoing = true;
        }

        public void DoWork()
        {
            while (KeepGoing)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(_processSleepSeconds * 1000);
            }
        }
    }
}