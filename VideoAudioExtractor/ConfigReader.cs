using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace VideoAudioExtractor
{
    public class ConfigReader
    {
        // Config elements base path
        private string _configBase = "/configuration/appSettings/";

        // Variables
        private int _processSleepSeconds = 10;
        private string _ipAddress = string.Empty;
        private int _port = 8000;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _dbConnectionString = string.Empty;
        private string _outputLocationPath = string.Empty;
        private bool _deleteVideos = false;
        private bool _audioSilenceRemove = false;
        private string _audiodBThreshold = "-40dB";
        private string _audioExportPath = string.Empty;
        private string _cameraName = string.Empty;

        private readonly XmlDocument _config = new XmlDocument();

        public ConfigReader(string configFile)
        {
            Console.WriteLine("Config loaded from: " + configFile);
            LoadConfig(configFile);
        }


        private void LoadConfig(string cwd)
        {
            _config.Load(cwd);
            _processSleepSeconds =
                IntegerType.FromString(_config.SelectSingleNode(_configBase + "processSleepSeconds").InnerText);
            _ipAddress = _config.SelectSingleNode(_configBase + "ipAddress").InnerText;
            _port = IntegerType.FromString(_config.SelectSingleNode(_configBase + "port").InnerText);
            _username = _config.SelectSingleNode(_configBase + "username").InnerText;
            _password = _config.SelectSingleNode(_configBase + "password").InnerText;
            _dbConnectionString = _config.SelectSingleNode(_configBase + "dbConnectionString").InnerText;
            _outputLocationPath = _config.SelectSingleNode(_configBase + "outputLocationPath").InnerText;
            _deleteVideos = _config.SelectSingleNode(_configBase + "deleteVideos").InnerText == "true";
            _audioSilenceRemove = _config.SelectSingleNode(_configBase + "audioSilenceRemove").InnerText == "true";
            _audiodBThreshold = _config.SelectSingleNode(_configBase + "audiodBThreshold").InnerText;
            _audioExportPath = _config.SelectSingleNode(_configBase + "audioExportPath").InnerText;
            _cameraName = _config.SelectSingleNode(_configBase + "cameraName").InnerText;
        }

        public int GetProcessSleepSeconds => _processSleepSeconds;
        public string GetIpAddress => _ipAddress;
        public int GetPort => _port;
        public string GetUserName => _username;
        public string GetPassword => _password;
        public string GetDbConnectionString => _dbConnectionString;
        public string GetOutputLocationPath => _outputLocationPath;
        public bool GetBoolDeleteVideos => _deleteVideos;
        public string GetAudioExportPath => _audioExportPath;
        public string GetCameraName => _cameraName;

        public bool GetAudioSilenceRemove => _audioSilenceRemove;

        public string GetAudiodBThreshold => _audiodBThreshold;
    }
}