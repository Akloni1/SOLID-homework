using P01.Stream_Progress.InformationFlow;
using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите тип: ");
            string type = Console.ReadLine();

            Factory factory = new Factory();

            switch (type)
            {
                case "File":
                    {

                        FlowInformation file = factory.create(type);
                        StreamProgressInfo streamProgressInfo = new StreamProgressInfo(file);
                        Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
                        break;
                    }
                case "Music":
                    {

                        FlowInformation music = factory.create(type);
                        StreamProgressInfo streamProgressInfo = new StreamProgressInfo(music);
                        Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
                        break;
                    }
            }
        }
    }
}
