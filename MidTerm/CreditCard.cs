using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class CreditCard : Payment
    {
        //Credit Card Properties
        public int CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CW { get; set; }

        //constructor
        public CreditCard(int AlbumPrice, int Quantity, int CreditCardNumber, string ExpirationDate, int CW) : base(AlbumPrice, Quantity)
        {
            this.CreditCardNumber = CreditCardNumber;
            this.ExpirationDate = ExpirationDate;
            this.CW = CW;

        }

        //method overrides


    }
}
