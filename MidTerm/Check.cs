using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Check : Payment
    {
        //Check property
        public int CheckNumber { get; set; }

        //Constructor
        public Check(int AlbumPrice, int Quantity, int CheckNumber) : base(AlbumPrice, Quantity)
        {
            this.CheckNumber = CheckNumber;
        }

        //Override Methods


    }
}
