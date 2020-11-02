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

        //method 

        public static void PayWithCredit()
        {
            int creditCardNum = UILibs.UserInputLibrary.GetCheckNumber("Enter your 16 digit credit card number: ");
            string expirationDate = UILibs.UserInputLibrary.GetCheckNumber("Enter your card expiration date (mm/yy): ");
            string cw = UILibs.UserInputLibrary.GetCheckNumber("Enter your card CW: ");

            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your receipt.");
            PrintShoppingBag();
            Console.WriteLine($"Paid with credit card#: {creditCardNum}\nExpiration Date: {expirationDate}\nCW {cw}");

        }


    }
}
