using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MidTerm
{
    public class RecordStore:Albums
    {

        public List<Albums> albums { get; set; }

        public RecordStore()
        {
        }
        //public void PrintAlbums()
        //{

        //    int inOut;
        //    //  while (!int.TryParse(userInput, out inOut))
        //    //{
        //    for (int i = 0; i < albums.Count; i++)
        //    {
        //        Console.WriteLine($"{i}) {albums[i].Title}");
        //    }
        //    // }
        //}
        public Albums CheckAlbum()
        {

                string userResponse = Console.ReadLine();
            int userNumber;
            while (!Int32.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("This entry is not valid, please enter a number.");
                userResponse = Console.ReadLine();
            }

            int albumIndex = int.Parse(userResponse);
            albumIndex = albumIndex - 1;
            albums[albumIndex].PrintInfo();
            return albums[albumIndex];
        }

    }
}
