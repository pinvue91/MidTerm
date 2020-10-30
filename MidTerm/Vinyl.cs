using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Vinyl:Albums
    {

        public string Title { get; set; }
        public Genre Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Vinyl()
        { }
        public Vinyl (string Title, Genre Category, string Artist, string Rating, double Price, DateTime DateTime, string Description)
        {
            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.DateTime = DateTime;
            this.Description = Description;
        }
    }
}
