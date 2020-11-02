using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MidTerm
{
    class TradeIn
    {

        public static void TradeInAlbum()
        {

            List<Album> albumList = new List<Album>();

            StreamReader reader = new StreamReader("../../../MidtermAlbums.txt");
            string albumRead = reader.ReadLine();
            while (albumRead != null) 
            {

                Album albumToAdd = new Album(); 

                string[] albumArray = albumRead.Split(",");

                albumToAdd.Title = albumArray[0]; 
                albumToAdd.Category = albumArray[1]; 
                albumToAdd.Artist = albumArray[2];
                albumToAdd.Rating = albumArray[3];
                albumToAdd.Price = albumArray[4];
                albumToAdd.Year = albumArray[5];
                albumToAdd.Description = albumArray[6];

                albumList.Add(albumToAdd);

                albumRead = reader.ReadLine();

            }

            reader.Close();

            //creating a new album object from user input and adding to the album list

            Album a = new Album();

            Console.WriteLine("Please enter the album you want to trade in:");
            a.Title = Console.ReadLine();
            Console.WriteLine("What is the category of this album?");
            a.Category = Console.ReadLine(); 
            Console.WriteLine("Please enter the Artist name:");
            a.Artist = Console.ReadLine();
            Console.WriteLine("Please enter your rating out of ten (e.g. 8/10):");
            a.Rating = Console.ReadLine();
            Console.WriteLine("What is the value of this album?");
            a.Price = Console.ReadLine();
            Console.WriteLine("What year did this album come out?");
            a.Year = Console.ReadLine();
            Console.WriteLine("Write a brief description of this album: ");
            a.Description = Console.ReadLine();



            albumList.Add(a);

            Console.WriteLine();
            Console.WriteLine($"Thanks for selling {a.Title} to us! Here's $3. That's all I have. Have a nice day!");

            StreamWriter streamWriter = new StreamWriter("../../../MidtermAlbums.txt");
            foreach (Album album in albumList)
            {
                streamWriter.WriteLine(album); //the TextWriter.WriteLine() method uses the ToString() method. You'll need to override ToString() in Albums class and add each property

            }

            streamWriter.Close();

        }
    }
}
