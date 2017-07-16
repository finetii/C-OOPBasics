using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> playList = new List<Song>();
            int numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] input = Console.ReadLine().Split(';');
                string artistName = input[0];
                string songName = input[1];
               

                try
                {
                    int[] songLenght = input[2].Split(':').Select(int.Parse).ToArray();
                    Song song = new Song(artistName, songName, songLenght[0], songLenght[1]);
                    playList.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

                Console.WriteLine($"Songs added: {playList.Count}");
                int totalMinuts = playList.Sum(m => m.Minutes);
                int totalSeconds = playList.Sum(s => s.Seconds);
                totalSeconds += totalMinuts * 60;
                int finalMinutes = totalSeconds / 60;
                int finalSeconds = totalSeconds % 60;
                int finalHours = finalMinutes / 60;
                finalMinutes %= 60;
                Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");
            
        }
    }
}
