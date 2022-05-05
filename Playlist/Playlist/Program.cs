using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] summerPlaylist;

            summerPlaylist = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
            AmountSongs(summerPlaylist);
        }

        static void AmountSongs(string[] playlist)
        {
            int playlistLength = playlist.Length;

            if(playlistLength == 8)
            {
                Console.WriteLine("summerStrut Playlist is ready to go!");
            }
            else if(playlistLength > 8)
            {
                Console.WriteLine("Too many songs!");

            }
            else
            {
                Console.WriteLine("Please add some songs!");

            }

        }
    }
}
