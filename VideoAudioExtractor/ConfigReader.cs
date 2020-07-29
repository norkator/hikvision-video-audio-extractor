using System;
using System.Xml;

namespace VideoAudioExtractor
{
    public class ConfigReader
    {
        private string test = "test";
        private XmlDocument _config = new XmlDocument();

        public ConfigReader(string configFile)
        {
            Console.WriteLine("Current working dir: " + configFile);
            LoadConfig(configFile);
        }


        private void LoadConfig(string cwd)
        {
            _config.Load(cwd);
        }

        public string GetTest => test;
    }
}