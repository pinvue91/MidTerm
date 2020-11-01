using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace MidTerm
{
    class CSVHelper : List<string[]>
    {
        public string csv = string.Empty;
        string separator = ".";
        public CSVHelper(string csv, string separator = "\",\"")
        {
            this.csv=csv;
            this.separator=separator;


            foreach (string line in Regex.Split(csv, System.Environment.NewLine).ToList().Where(s => !string.IsNullOrEmpty(s)))
            {
                string[] values = Regex.Split(line, separator);


                for (int i = 0; i < values.Length; i++)
                {
                    //trim values?
                    values[i] = values[i].Trim('\"');
                }
                this.Add(values);
            }
        }

        //public List<Albums> GetAlbums(string csvContent)
        //{
        //    List<Albums> albums = new List<Albums>();
        //    CSVHelper csv = new CSVHelper(csvContent);


        //    foreach (string[] line in csv)
        //    {
        //        Albums album = new Albums();
        //        albums.Name = line[0];
        //        albums.Category = line[1];
        //        albums.Artist = line[2];
        //        albums.Rating = line[3];
        //        albums.Price = line[4];
        //        albums.Year = line[5];
        //        albums.Description = line[6];
        //        albums.Add(album);


        //    }
        //    return albums;
        //}


    }
}
