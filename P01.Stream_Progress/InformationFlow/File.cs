﻿namespace P01.Stream_Progress.InformationFlow
{
    public class File: FlowInformation
    {
        private string name;

        public File(string name, int length)
        {
            this.name = name; 
        }

        public int Length { get ; set; }

        //   public int Length { get; set; }
        //
        //   public int BytesSent { get; set; }
    }
}
