using System;
using System.Xml;

namespace VideoAudioExtractor
{
    public class ConfigReader
    {
        private string test = "test";
        private XmlDocument _config = new XmlDocument();

        public ConfigReader()
        {
        }


        private void LoadConfig()
        {
            // _config.Load();
        }

        public string GetTest => test;
    }
}