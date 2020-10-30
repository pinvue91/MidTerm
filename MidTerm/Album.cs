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
        public Genre Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Albums()
        { }
        public Albums(string Title, Genre Category, string Artist, string Rating, double Price, DateTime DateTime, string Description)
        {
            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.DateTime = DateTime;
            this.Description = Description;
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

        public void PrintAlbum()

        {
            Console.WriteLine($"{Title}");
        }
       
        

    }
}
