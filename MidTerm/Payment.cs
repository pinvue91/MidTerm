using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Payment
    {

        //properties
        public int AlbumPrice { get; set; }
        public int Quantity { get; set; }
        public double SalesTax { get; set; } = .6;

        //constructor
        public Payment(int AlbumPrice, int Quantity)
        {
            this.AlbumPrice = AlbumPrice;
            this.Quantity = Quantity;

        }

        //virtual method
        public virtual void GetPaymentInfo() { }




    }
}
