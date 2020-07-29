using System;

namespace VideoAudioExtractor
{
    static class Program
    {
        private static readonly ConfigReader ConfigReader = new ConfigReader();

        static void Main(string[] args)
        {
            Console.WriteLine(ConfigReader.GetTest);
        }
    }
}