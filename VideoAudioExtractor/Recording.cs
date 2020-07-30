using System;
using System.Numerics;

namespace VideoAudioExtractor
{
    public class Recording
    {
        // Variables
        private readonly string _cameraName = String.Empty;
        private readonly BigInteger _id;
        private readonly string _fileName;
        private readonly string _startTime;
        private readonly string _endTime;
        private DateTime _dtStartTime;
        private DateTime _dtEndTime;

        // Constructor
        public Recording(BigInteger id, string fileName, string startTime, string endTime)
        {
            // _cameraName = cameraName;
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

        public void SetDtEndTime(DateTime endTime)
        {
            _dtEndTime = endTime;
        }

        public DateTime GetDtEndTime()
        {
            return _dtEndTime;
        }

        public void SetDtStartTime(DateTime startTime)
        {
            _dtStartTime = startTime;
        }

        public DateTime GetDtStartTime()
        {
            return _dtStartTime;
        }
    }
}