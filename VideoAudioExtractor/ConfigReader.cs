using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace VideoAudioExtractor
{
    public class ConfigReader
    {
        private string _configBase = "/configuration/appSettings/";
        private string _ipAddress = string.Empty;
        private int _port = 8000;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private readonly XmlDocument _config = new XmlDocument();

        public ConfigReader(string configFile)
        {
            Console.WriteLine("Config loaded from: " + configFile);
            LoadConfig(configFile);
        }


        private void LoadConfig(string cwd)
        {
            _config.Load(cwd);
            _ipAddress = _config.SelectSingleNode(_configBase + "ipAddress").InnerText;
            _port = IntegerType.FromString(_config.SelectSingleNode(_configBase + "port").InnerText);
            _username = _config.SelectSingleNode(_configBase + "username").InnerText;
            _password = _config.SelectSingleNode(_configBase + "password").InnerText;
        }

        public string GetIpAddress => _ipAddress;
        public int GetPort => _port;
        public string GetUserName => _username;
        public string GetPassword => _password;
    }
}