using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Albums
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }
        public double Price { get; set; }

        public Albums()
        { }
        public Albums(string Title, Genre Category, string Description, string Review, double Price)
        {
            this.Title = Title;
            this.Category = Category;
            this.Description = Description;
            this.Review = Review;
            this.Price = Price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Review: { Review}");
            Console.WriteLine($"Price: {Price}");
        }

    }
}
