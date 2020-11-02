using System;
using System.IO;
using System.Linq;

namespace MidTerm
{
    public class Album
    {

        public string Title { get; set; }
        public string Category { get; set; }
        public string Artist { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }

        //StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
        public Album()
        { }

       
        public Album(string Title, string Category, string Artist, string Rating, string Price, string Year, string Description)
        {
        
            this.Title = Title;
            this.Category = Category;
            this.Artist = Artist;
            this.Rating = Rating;
            this.Price = Price;
            this.Year = Year;
            this.Description = Description;
        }

        




        public static Album FromCsv(string csvline)
        {
            //populates list with CSV File

            string[] values = csvline.Split(',');

            Album albums = new Album();
          
            {
                for (int i = 0; i < values.Length - 1; i++)
                {


                    albums.Title = (values[0]);
                    albums.Category = (values[1]);
                    albums.Artist = (values[2]);
                    albums.Rating = (values[3]);
                    albums.Price = (values[4]);
                    albums.Year = (values[5]);
                    albums.Description = (values[6]);


                }

            }

            return albums;

        }





        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Review: { Rating}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine();

        }

        public void PrintTitles()
        {
            int counter = 1;

            foreach (var title in Title)
            {
                Console.WriteLine($"Title {counter}: {title}");
                counter++;
            }
        
        }
        public void PrintCategory()
        {
            int counter = 1;

            foreach (var cat in Category)
            {
                Console.WriteLine($"Category {counter}: {cat}");
                counter++;
            }

        }

        public void PrintArtist()
        {
            int counter = 1;

            foreach (var art in Artist)
            {
                Console.WriteLine($"Artist {counter}: {art}");
                counter++;
            }

        }

        public void PrintRating()
        {
            int counter = 1;

            foreach (var rat in Rating)
            {
                Console.WriteLine($"Rating {counter}: {rat}");
                counter++;
            }

        }

        public void PrintPrice()
        {
            int counter = 1;

            foreach (var price in Price)
            {
                Console.WriteLine($"Price {counter}: {price}");
                counter++;
            }

        }

        public void PrintYear()
        {
            int counter = 1;

            foreach (var year in Year)
            {
                Console.WriteLine($"Year {counter}: {year}");
                counter++;
            }

        }

        public void PrintDescription()
        {
            int counter = 1;

            foreach (var description in Description)
            {
                Console.WriteLine($"Description {counter}: {description}");
                counter++;
            }

        }
        public virtual void Preview()
        {

        }

        //override ToString()
        public override string ToString()
        {
            return String.Format($"{Title},{Category},{Artist},{Rating},{Price}, {Description}");
        }



    }
}
