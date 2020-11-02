using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MidTerm
{
    public class RecordStore:Album
    {

        public string Title { get; set; }
        public string Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }

        //StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
     


        public RecordStore(string Title, string Category, string Artist, string Rating, string Price, string Year, string Description):base(Title,Category,Artist,Rating,Price,Year,Description)
        {

            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.Year = Year;
            this.Description = Description;
        }
        public List<Album> albums { get; set; }

        public RecordStore()
        {
        }
        public void PrintAlbums()
        {

            int inOut;
            //  while (!int.TryParse(userInput, out inOut))
            //{
            for (int i = 1; i < Title.Length; i++)
            {
                Console.WriteLine($"{i}) {albums[i].Title}");
            }
            // }
        }
        public Album CheckAlbum()
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
