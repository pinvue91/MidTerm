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

            List<Album> albums = File.ReadAllLines("C:\\Users\\Duncan\\Documents\\MidtermAlbums.txt").Skip(1).Select(v => Album.FromCsv(v)).ToList();

            RecordStore bob = new RecordStore();
            bob.PrintAlbums();


            Console.WriteLine("Welcome to our record store. Please select an album");


          

        }



    }

}
    





