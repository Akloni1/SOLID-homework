using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress.InformationAboutBytesSent
{
    internal class MusicStream: IStream
    {
        public MusicStream(int bytesSent)
        {
            BytesSent = bytesSent;
        }

           public int BytesSent { get; set; }
    }
}
