using System.Numerics;

namespace VideoAudioExtractor
{
    public class Recording
    {
        // Variables
        private readonly BigInteger _id;
        private readonly string _fileName;
        private readonly string _startTime;
        private readonly string _endTime;

        // Constructor
        public Recording(BigInteger id, string fileName, string startTime, string endTime)
        {
            _id = id;
            _fileName = fileName;
            _startTime = startTime;
            _endTime = endTime;
        }

        public BigInteger GetId()
        {
            return _id;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public string GetStartTime()
        {
            return _startTime;
        }

        public string GetEndTime()
        {
            return _endTime;
        }
    }
}