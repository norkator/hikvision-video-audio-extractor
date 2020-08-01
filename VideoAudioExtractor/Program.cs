using System;
using System.Globalization;
using System.Threading;
using FFMpegCore;

namespace VideoAudioExtractor
{
    static class Program
    {
        // Todo: fix this to look application installation path
        private static readonly string configFile =
            "C:\\Users\\Martin\\Documents\\RiderProjects\\hikvision-video-audio-extractor\\config.xml";

        private static readonly ConfigReader ConfigReader = new ConfigReader(configFile);
        private static NvrConnector _nvrConnector = null;

        static void Main(string[] args)
        {
            
            /*
            // This will initiate login to nvr
            _nvrConnector = new NvrConnector(
                ConfigReader.GetIpAddress,
                ConfigReader.GetPort,
                ConfigReader.GetUserName,
                ConfigReader.GetPassword,
                ConfigReader.GetDbConnectionString,
                ConfigReader.GetOutputLocationPath,
                ConfigReader.GetAudioExportPath,
                ConfigReader.GetBoolDeleteVideos,
                ConfigReader.GetCameraName
            );
            */
            
            //Thread.Sleep(5 * 1000);
            //_nvrConnector.LogOutNvr();


            try
            {
                FFMpeg.ExtractAudio(
                    "C:\\Users\\Martin\\Desktop\\output\\ch01_00000000086006201.mp4",
                    "C:\\Users\\Martin\\Desktop\\output\\ch01_00000000086006201.mp3");
            }
            catch (TypeInitializationException e)
            {
                Console.WriteLine(e);
            }


            /*
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
            */
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