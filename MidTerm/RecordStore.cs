using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MidTerm
{
    public class RecordStore
    {

        public List<Albums> albums { get; set; }
        public RecordStore()
        {
            
                using (var reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt"))
            { 
                string line = reader.ReadLine();
                var values = line.Split(',');

                string Titles = values[0];
                string Genre = values[1];
                string Artist = values[2];
                string Rating = values[3];
                double Price = Convert.ToDouble(values[4]);
                string DateTime = values[5];
                string Description = values[6];
            //albums = new List<Albums> (Titles,Genre,Artist, Rating, Price,DateTime, Description );
                
            }
            
            
            
        }
    }
}
