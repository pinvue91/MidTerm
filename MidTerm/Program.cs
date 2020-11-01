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
using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;

namespace MidTerm
{

    class Program
    {


        static void Main(string[] args)

        {
            RecordStore bob = new RecordStore();

            List<Albums> albums = File.ReadAllLines("C:\\Users\\Duncan\\Documents\\MidtermAlbums.txt").Skip(1).Select(v => Albums.FromCsv(v)).ToList();

            bob.PrintAlbums();


            Console.WriteLine("Welcome to our record store. Please select an album");




            //DataTable dataTable = new DataTable();
            //string fullText;
            //string[] rowValues;
            //var filePath = @"C:\\Users\Duncan\Documents\MidtermAlbums.txt";
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        fullText = sr.ReadToEnd().ToString(); //read full file text  
            //        string[] rows = fullText.Split('\n'); //split full file text into rows  
            //        for (int i = 0; i < rows.Count() - 1; i++)
            //        {
            //            rowValues = rows[i].Split(','); //split each row with comma to get individual values  
            //            {
            //                if (i == 0)
            //                {
            //                    for (int j = 0; j < rowValues.Count(); j++)
            //                    {
            //                        dataTable.Columns.Add(rowValues[j].Trim()); //add headers  
            //                    }
            //                }
            //                else
            //                {
            //                    DataRow dr = dataTable.NewRow();
            //                    for (int k = 0; k < rowValues.Count(); k++)
            //                    {
            //                        dr[k] = rowValues[k].ToString();
            //                    }
            //                    dataTable.Rows.Add(dr); //add other rows  
            //                }
            //            }
            //        }
            //    }

            //    List<Albums> CategoryList = new List<Albums>();
            //    CategoryList = (from DataRow dr in dataTable.Rows
            //                    select new Albums()
            //                    {
            //                        Title = dr["Title"].ToString(),
            //                        Category = dr["Genre"].ToString(),
            //                        Artist = dr["Artist"].ToString(),
            //                        Rating = dr["10/10"].ToString(),
            //                        Price = dr["Price"].ToString(),
            //                        Year = dr["Date Released"].ToString(),
            //                        Description = dr["Review"].ToString()
            //                    }).ToList();


            //    for (int i = 0; i < CategoryList.Count; i++)
            //    {
            //        Console.WriteLine(CategoryList[i].Title);
            //        Console.WriteLine(CategoryList[i].Category);
            //        Console.WriteLine(CategoryList[i].Artist);
            //        Console.WriteLine(CategoryList[i].Rating);
            //        Console.WriteLine(CategoryList[i].Price);
            //        Console.WriteLine(CategoryList[i].Year);
            //        Console.WriteLine(CategoryList[i].Description);
            //    }

            //    Console.ReadLine();













            //for (int i = 0; i < allInfo.Length; i++)
            //{
            //    for (int j = 0; j < allInfo.Length; j++)
            //    {

            //        albums.Title = allInfo[i];
            //        albums.Category = allInfo[i + 1];
            //        albums.Artist = allInfo[i + 1];
            //        albums.Rating = allInfo[i + 1];
            //        albums.Price = allInfo[i + 1];
            //        albums.Year = allInfo[i + 1];
            //        albums.Description = allInfo[i + 1];
            //    }
            //}

            // var lines = System.IO.File.ReadAllLines("C:\\Offers.csv");

            //foreach (string item in allInfo)
            //{
            //    var values = item.Split(',').Skip(1);
            //    //need to check which type of vehicle is it
            //    for (int i = 0; i < allInfo.Length; i++)
            //    {
            //        var valuesSeparated = values.ElementAt(i).Split(',');
            //        for (int j = 0; j < allInfo.Length; j++)
            //        {
            //            albumList.Add(new Albums()
            //            {
            //                Title = values.ElementAt(i),
            //                Category = values.ElementAt(i),
            //                Artist = values.ElementAt(i),
            //                Rating = values.ElementAt(i),
            //                Price = values.ElementAt(i),
            //                Year = values.ElementAt(i),
            //                Description = values.ElementAt(i)
            //            });
            //        }
            //    }



        }



        //string Titles = values[0];
        //string Genre = values[1];
        //string Artist = values[2];
        //string Rating = values[3];
        //double Price = Convert.ToDouble(values[4]);
        //string DateTime = values[5];
        //string Description = values[6];



        //  for (int i = 0; i < length; i++)
        //{
        //    for (int i = 0; i < length; i++)
        //    {
        //        albums.Title=\
        //    }
        //}




        //table.Add(line.Split(line, ','));

        //            Titles.Add(values[0]);
        //            Genre.Add(values[1]);
        //            Artist.Add(values[2]);
        //            Rating.Add(values[3]);
        //            Price.Add(values[4]);
        //            DateTime.Add(values[5]);
        //            Description.Add(values[6]);
        //            string line = reader.ReadLine();
        //            var values = line.Split(',');

        //            table.Add(line.Split(line, ','));

        //            Titles.Add(values[0]);
        //            Genre.Add(values[1]);
        //            Artist.Add(values[2]);
        //            Rating.Add(values[3]);
        //            Price.Add(values[4]);
        //            DateTime.Add(values[5]);
        //            Description.Add(values[6]);




        //            while (!reader.EndOfStream)
        //        {

        //            try
        //            {

        //                string line = reader.ReadLine();
        //                var values = line.Split(',');

        //                table.Add(line.Split(line, ','));

        //                Titles.Add(values[0]);
        //                Genre.Add(values[1]);
        //                Artist.Add(values[2]);
        //                Rating.Add(values[3]);
        //                Price.Add(values[4]);
        //                DateTime.Add(values[5]);
        //                Description.Add(values[6]);
        //            }
        //            catch (IndexOutOfRangeException)
        //            {

        //            }
        //            foreach (var ret in Titles)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            foreach (var ret in Genre)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //            foreach (var ret in Artist)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //            foreach (var ret in Rating)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //            foreach (var ret in Price)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //            foreach (var ret in DateTime)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //            foreach (var ret in Description)
        //            {
        //                Console.WriteLine(ret);
        //            }
        //            Console.WriteLine();
        //        }
        //        reader.Close();
        //    }
        //}



    }

}
    





