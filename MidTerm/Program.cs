using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)

        {


            // List<Albums> albums = new List<Albums>();


            Console.WriteLine("Hello World!");
            // StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            // StringBuilder sb = new StringBuilder(reader.ToString());
            // Console.WriteLine(sb.ToString());
            //string filePath = File.ReadAllText(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            //  Console.WriteLine(filePath);
           // var allInfo = File.ReadAllLines(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");

            using (var reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt"))
            {

                List<string> Titles = new List<string>();
                List<string> Genre = new List<string>();
                List<string> Artist = new List<string>();
                List<string> Rating = new List<string>();
                List<string> Price = new List<string>();
                List<string> DateTime = new List<string>();
                List<string> Description = new List<string>();
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Albums albums = new Albums[]($"{Titles},{ Genre}, {Artist}, {Rating}, {Price}, {DateTime}, {Description}");
                        //{
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        Titles.Add(values[0]);
                        Genre.Add(values[1]);
                        Artist.Add(values[2]);
                        Rating.Add(values[3]);
                        Price.Add(values[4]);
                        DateTime.Add(values[5]);
                        Description.Add(values[6]);

                    }
                    catch(IndexOutOfRangeException)
                    {

                    }

                    Console.WriteLine();
                    foreach (var ret in Artist)
                    {
                        Console.WriteLine(ret);
                    }
                    Console.WriteLine();
                    foreach (var ret in Rating)
                    {
                        Console.WriteLine(ret);
                    }
                    Console.WriteLine();
                    foreach (var ret in Price)
                    {
                        Console.WriteLine(ret);
                    }
                    Console.WriteLine();
                    foreach (var ret in DateTime)
                    {
                        Console.WriteLine(ret);
                    }
                    Console.WriteLine();
                    foreach (var ret in Description)
                    {
                        Console.WriteLine(ret);
                    }
                    Console.WriteLine();
                }
            }
        }


    }


}

