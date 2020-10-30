using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;
using CsvHelper;
using System.Linq;


namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)

        {
            

            var status = new List<Albums>();
            var lines = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt").Skip(1);

            foreach (var line in lines)
            {
                var values = line.Split(",");
                var stats = new Albums();
                var props = typeof(Albums).GetProperties();


                for (int i = 0; i < values.Length - 1; i++)
                {
                    props[i].SetValue(stats, values[i]);
                }
                status.Add(stats);
            }

            foreach (var item in status)
            {
                Console.WriteLine(item);
            }
            //    string filePath = @"C:\\Users\Duncan\Documents\MidtermAlbums.txt";
            //    StreamReader reader = null;
            //    if (File.Exists(filePath))
            //    {
            //        reader = new StreamReader(File.OpenRead(filePath));
            //        List<string> albums = new List<string>();
            //        while (!reader.EndOfStream)
            //        {
            //            var line = reader.ReadLine();
            //            var values = line.Split(',');
            //            foreach (var item in values)
            //            {
            //                albums.Add(item);
            //            }
            //            foreach (var column1 in albums)
            //            {
            //                Console.WriteLine(column1);
            //            }

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("nothing here");
            //    }
            //}





            //            Console.WriteLine("Hello World!");
            //        // StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            //        // StringBuilder sb = new StringBuilder(reader.ToString());
            //        // Console.WriteLine(sb.ToString());
            //        string filePath = File.ReadAllText(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            //        //  Console.WriteLine(filePath);
            //        var allInfo = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            //        var table = new List<string[]>();
            //        using (var reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt"))
            //        {
            //            string line = reader.ReadLine();
            //            var values = line.Split(',');

            //string Titles = values[0];
            //string Genre = values[1];
            //string Artist = values[2];
            //           string Rating =values [3];
            //           double Price = Convert.ToDouble(values[4]);
            //            string DateTime =values [5];
            //           string Description = values[6];

            //            //Albums albums = new Albums[7]($"{Titles},{ Genre}, {Artist}, {Rating}, {Price}, {DateTime}, {Description}");




            //            //table.Add(line.Split(line, ','));

            //            //Titles.Add(values[0]);
            //            //Genre.Add(values[1]);
            //            //Artist.Add(values[2]);
            //            //Rating.Add(values[3]);
            //            //Price.Add(values[4]);
            //            //DateTime.Add(values[5]);
            //            //Description.Add(values[6]);
            //           //string line = reader.ReadLine();
            //           // var values = line.Split(',');

            //            //table.Add(line.Split(line, ','));

            //            //Titles.Add(values[0]);
            //            //Genre.Add(values[1]);
            //            //Artist.Add(values[2]);
            //            //Rating.Add(values[3]);
            //            //Price.Add(values[4]);
            //            //DateTime.Add(values[5]);
            //            //Description.Add(values[6]);




            //            while (!reader.EndOfStream)
            //            {

            //                try
            //                {

            //                    string line = reader.ReadLine();
            //                    var values = line.Split(',');

            //                    table.Add(line.Split(line, ','));

            //                    Titles.Add(values[0]);
            //                    Genre.Add(values[1]);
            //                    Artist.Add(values[2]);
            //                    Rating.Add(values[3]);
            //                    Price.Add(values[4]);
            //                    DateTime.Add(values[5]);
            //                    Description.Add(values[6]);
            //                }
            //                catch(IndexOutOfRangeException)
            //                {

            //                }
            //                foreach (var ret in Titles)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                foreach (var ret in Genre)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //                foreach (var ret in Artist)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //                foreach (var ret in Rating)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //                foreach (var ret in Price)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //                foreach (var ret in DateTime)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //                foreach (var ret in Description)
            //                {
            //                    Console.WriteLine(ret);
            //                }
            //                Console.WriteLine();
            //            }
            //            reader.Close();
            //        } 
        }


    }
}



