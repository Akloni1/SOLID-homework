using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress.InformationFlow
{
    public class Music: FlowInformation
    {
        private string artist;
        private string album;
        public int Length { get; set; }

        public Music(string artist, string album, int length)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
           
        }

    }
}
