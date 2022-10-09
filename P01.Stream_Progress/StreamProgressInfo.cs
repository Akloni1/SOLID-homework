using System;
using System.Collections.Generic;
using System.Text;
using P01.Stream_Progress.InformationFlow;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private FlowInformation flowInformation;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(FlowInformation flowInformation)
        {
            this.flowInformation = flowInformation;
        }

        public int CalculateCurrentPercent()
        {
            return (this.flowInformation.BytesSent * 100) / this.flowInformation.Length;
        }
    }
}
