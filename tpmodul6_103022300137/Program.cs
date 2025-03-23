using System;

namespace tpmodul6_103022300137
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - GUMILAR HARI SUBAGJA");
            for (int i = 0; i < 5; i++)  
            {
                video.IncreasePlayCount(2000000);
            }
            video.PrintVideoDetails();
        }
    }
}