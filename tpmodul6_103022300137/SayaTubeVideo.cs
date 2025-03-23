using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tpmodul6_103022300137
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 100, "Judul tidak valid");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000 && count >= 0, "Penambahan play count terlalu besar atau negatif");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: terjadi overflow saat menambahkan play count.");
                Console.WriteLine(e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah view: " + playCount);
        }
    }
}
