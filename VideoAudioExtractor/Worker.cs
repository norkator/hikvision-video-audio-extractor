using System.Threading;
using System.Threading.Tasks;

namespace VideoAudioExtractor
{
    public class Worker
    {
        // Variables
        public bool KeepGoing { get; set; }
        private readonly int _processSleepSeconds;
        private static NvrConnector _nvrConnector = null;

        public Worker(int processSleepSeconds, ConfigReader configReader)
        {
            _processSleepSeconds = processSleepSeconds;
            var configReader1 = configReader;
            KeepGoing = true;

            // Init NvrConnector
            _nvrConnector = new NvrConnector(
                configReader1.GetIpAddress,
                configReader1.GetPort,
                configReader1.GetUserName,
                configReader1.GetPassword,
                configReader1.GetDbConnectionString,
                configReader1.GetOutputLocationPath,
                configReader1.GetAudioExportPath,
                configReader1.GetBoolDeleteVideos,
                configReader1.GetCameraName,
                configReader1.GetAudioSilenceRemove,
                configReader1.GetAudiodBThreshold
            );
        }

        public void RunCameraWorker()
        {
            while (KeepGoing)
            {
                // Run process
                Task.Run(_nvrConnector.StartProcess).Wait();
                // Sleep before next run
                Thread.Sleep(_processSleepSeconds * 1000);
            }
        }
    }
}