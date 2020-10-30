using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MidTerm
{
    public class Albums
    {

        public string Title { get; set; }
        public string Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }

        public Albums()
        { }

        //public Albums(string line)
        //{
        //var listOfObjects = File.ReadLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt").Select(line => new Albums(line)).ToList();
        //    var split = line.Split(',');
        //    Title = split[0];
        //    Category = split[1];
        //    Artist = split[2];
        //    Rating = split[3];
        //    Price = Convert.ToDouble(split[4]);
        //    DateTime = Convert.ToDateTime(split[5]);
        //    Description = split[6];
        //}
        public Albums(string Title, string Category, string Artist, string Rating, string Price, string Year, string Description)
        {
            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.Year = Year;
            this.Description = Description;
        }
        public void ReadCsv()
        {
            var status = new List<Albums>();
            var lines = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt").Skip(1);

            foreach (var line in lines)
            {
                var values = line.Split(",");
                var stats = new Albums();
                var props = typeof(Albums).GetProperties();
              

                for (int i = 0; i < values.Length-1; i++)
                {
                    props[i].SetValue(stats, values[i]);
                }
                status.Add(stats);
            }

        }





        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Review: { Rating}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
        }


        //public List<Albums> GetAlbums(string[] csvArray)
        //{
        //    List<Albums> albums = new List<Albums> { };
        //    String[] csv = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
        //    foreach (string item in csv)
        //    {
        //        var fields = item.Split(',');
        //        var row = albums.ToList();
        //    }


        //    using (var reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt"))
        //    {
        //        string line = reader.ReadLine();
        //        var values = line.Split(',');
        //    }
        //    return albums;
        //}

        public void PrintAlbum()

        {
            Console.WriteLine($"{Title}");
        }



    }
}
