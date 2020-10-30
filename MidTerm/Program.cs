using System;
using System.IO;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            // StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            // StringBuilder sb = new StringBuilder(reader.ToString());
            // Console.WriteLine(sb.ToString());
            string filePath = File.ReadAllText(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            //  Console.WriteLine(filePath);
            var allInfo = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");

            using (var reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt"))
            {
                List<string> Titles = new List<string>();
                List<string> Genre = new List<string>();
                List<string> Artist = new List<string>();
                List<string> Rating = new List<string>();
                List<string> Price = new List<string>();
                List<string> DateTime = new List<string>();
                List<string> Description = new List<string>();
                //while(!reader.EndOfStream)
                //{
                var line = reader.ReadLine();
                var values = line.Split(',');

                Titles.Add(values[1]);
                Genre.Add(values[2]);
                Artist.Add(values[3]);
                Rating.Add(values[4]);
                Price.Add(values[5]);
                // DateTime.Add(values[6]);
                //Description.Add(values[7]);
                

                //foreach (var ret in Titles)
                //{

                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in Genre)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in Artist)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in Rating)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in Price)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in DateTime)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //foreach (var ret in Description)
                //{
                //    Console.WriteLine(ret);
                //}
                //Console.WriteLine();
                //}
            }

            //            var path= @"C:\\Users\Duncan\Documents\MidtermAlbums.txt"
            //using (TextFieldParser cvsParser = new TextFieldParser(path))
            //            {

            //            }







            //    foreach (var s in filePath)
            //    {
            //Console.WriteLine(s);        //use string reader and string writer to enter a new album

            //}
        }


    }
}
