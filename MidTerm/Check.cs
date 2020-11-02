using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
        public static void PayWithCheck()
        {
            string checkNum = UILibs.UserInputLibrary.GetCheckNumber("Enter your 8 digit check number: ");
            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Thanks for shopping with us. Here's your receipt\n");

            Checkout.PrintReceipt();
            Console.WriteLine($"Paid in full with check #: {checkNum}");

            Thread.Sleep(5000);
            Console.Clear();
            Checkout.ShoppingBag = new List<ItemOrder>();
            Checkout.actions.RemoveAt(2);
        }

    }
}
