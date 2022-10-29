using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress.InformationAboutBytesSent
{
    internal class FileStream: IStream
    {
        public FileStream(int bytesSent)
        {
            BytesSent = bytesSent;
        }

        public int BytesSent { get; set; }
    }
}
