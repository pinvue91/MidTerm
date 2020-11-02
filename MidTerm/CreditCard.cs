using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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

            Console.WriteLine("Enter your 16 digit credit card number: ");

            int creditCardNum;

            while (!int.TryParse(Console.ReadLine(), out creditCardNum) && creditCardNum.ToString().Length != 16)
            {
                Console.WriteLine("Invalid credit card number!\nPlease enter a 16 digit credit card number:");
                creditCardNum = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter your card expiration date (mm/yy): ");
            string expirationDate = Console.ReadLine();

            Console.WriteLine("Enter your 3 digit card CW: ");
            int cw = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your receipt.");
            Checkout.PrintShoppingBag();
            Console.WriteLine($"Paid with credit card#: {creditCardNum}\nExpiration Date: {expirationDate}\nCW: {cw}");

        }


    }
}
