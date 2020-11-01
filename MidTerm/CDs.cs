using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{

    class CDs:Albums


    {
        public override void Preview()
        {
            Console.WriteLine("Which CD would you like to preview?");
            Console.WriteLine();
        }
        public CDs()
        { }
        public CDs(string Title, string Category, string Artist, string Rating, string Price, string Year, string Description):base(Title,Category,Artist, Rating, Price, Year, Description)
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
