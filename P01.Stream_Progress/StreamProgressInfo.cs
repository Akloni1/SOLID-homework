using System;
using System.Collections.Generic;
using System.Text;
using P01.Stream_Progress.InformationAboutBytesSent;
using P01.Stream_Progress.InformationFlow;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private FlowInformation _flowInformation;
        private IStream _stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(FlowInformation flowInformation, IStream stream)
        {
            _flowInformation = flowInformation;
            _stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (_stream.BytesSent * 100) / _flowInformation.Length;
        }
    }
}
