using System;
using System.Threading;

namespace VideoAudioExtractor
{
    static class Program
    {
        private static readonly string configFile =
            "C:\\Users\\Martin\\Documents\\RiderProjects\\hikvision-video-audio-extractor\\config.xml";

        private static readonly ConfigReader ConfigReader = new ConfigReader(configFile);

        static void Main(string[] args)
        {
            Worker worker = new Worker(ConfigReader.GetProcessSleepSeconds);
            Thread t = new Thread(worker.DoWork);
            t.IsBackground = true;
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
        private int _processSleepSeconds;

        public Worker(int processSleepSeconds)
        {
            this._processSleepSeconds = processSleepSeconds;
            KeepGoing = true;
        }

        public void DoWork()
        {
            while (KeepGoing)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(this._processSleepSeconds * 1000);
            }
        }
    }
}