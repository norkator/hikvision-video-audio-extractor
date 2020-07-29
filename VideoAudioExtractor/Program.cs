using System;
using System.IO;

namespace VideoAudioExtractor
{
    static class Program
    {
        private static readonly string configFile =
            "C:\\Users\\Martin\\Documents\\RiderProjects\\hikvision-video-audio-extractor\\VideoAudioExtractor\\config.xml";

        private static readonly ConfigReader ConfigReader = new ConfigReader(configFile);

        static void Main(string[] args)
        {
            Console.WriteLine(ConfigReader.GetTest);
        }
    }
}