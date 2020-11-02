using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //RecordStore bob = new RecordStore();
                List<Album> albums = File.ReadAllLines("../../../MidtermAlbums.txt").Skip(1).Select(v => Album.FromCsv(v)).ToList();
                Checkout co = new Checkout(albums);
                co.Start();
            }
        }
    }
}
