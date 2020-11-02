using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Cassette :Album

    {


        public Cassette()
        { }
        public Cassette(string Title, string Category, string Artist, string Rating, string Price, string Year, string Description) : base(Title, Category, Artist, Rating, Price, Year, Description)
        {
            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.Year = Year;
            this.Description = Description;
        }


    }
}
