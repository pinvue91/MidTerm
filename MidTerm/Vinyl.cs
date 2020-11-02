using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Vinyl:Album
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }


        public override void Preview()
        {
            Console.WriteLine("What would you like to listen to?");
            string userResponse = Console.ReadLine();
            int albumIndex = int.Parse(userResponse);
            for (int i = 0; albumIndex < 21; i++)
            {
                Console.WriteLine(Title[albumIndex]);
                if (albumIndex > 20)
                {
                    Console.WriteLine("Please select an album");
                }
                break;
            }
        }

        public Vinyl()
        { }

        public Vinyl (string Title, string Category, string Artist, string Rating, double Price, DateTime DateTime, string Description)
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
