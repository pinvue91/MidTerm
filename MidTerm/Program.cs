using System;
using System.IO;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;


namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        StreamReader reader = new StreamReader(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
        string filePath = File.ReadAllText(@"C:\\Users\Duncan\Documents\MidtermAlbums.txt");
            foreach (var s in filePath)
            {
        Console.WriteLine(filePath.Split.ToString("\n"+ "."));        //use string reader and string writer to enter a new album

            }
        }

    }
}
