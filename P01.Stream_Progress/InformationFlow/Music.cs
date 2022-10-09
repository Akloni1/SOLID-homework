using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress.InformationFlow
{
    public class Music: FlowInformation
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
            :base(length, bytesSent)
        {
            this.artist = artist;
            this.album = album;
            //Length = length;
            //BytesSent = bytesSent;
        }

      // public int Length { get; set; }
      //
      // public int BytesSent { get; set; }
    }
}
