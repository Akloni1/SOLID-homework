using P01.Stream_Progress.InformationFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    internal class Factory
    {
        public FlowInformation create(string type)
        {
            if (type.Equals("File"))
            {
                return new File("MyFile",7777,4444);
            }
            else if (type.Equals("Music"))
            {

                return new Music("Lumen", "Три пути", 7777, 3333);
            }
          
            else return null;
        }
    }
}
