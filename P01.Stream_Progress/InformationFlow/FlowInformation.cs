using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress.InformationFlow
{
    public abstract class FlowInformation
    {
        public int Length { get; set; }

        public int BytesSent { get; set; }
        public FlowInformation(int length, int bytesSent)
        {
            Length = length;
            BytesSent = bytesSent;
        }
       
    }
}
