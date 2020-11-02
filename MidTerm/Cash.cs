using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Claims;
using System.Text;
using System.Threading;

namespace MidTerm
{
    class Cash : Payment
    {
        //no unique properites


        //constructor
        public Cash(int AlbumPrice, int Quantity) : base(AlbumPrice, Quantity)
        {

        }


        //Methods
        public static void PayWithCash(int totalPrice)
        {
            bool enoughCash = false;

            Console.WriteLine("Please enter your total cash payment: ");

            int cashPayment = int.Parse(Console.ReadLine());

            int change = cashPayment - totalPrice;

            while (enoughCash == false)
            {
                if(change >=0)
                {
                    enoughCash = true;
                }
                
                
                if (change < 0)
                {
                    Console.WriteLine($"That's not enough. The total is {totalPrice}. Please enter your total cash payment: ");
                    cashPayment = int.Parse(Console.ReadLine());
                }
            }



            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your receipt.");
            Checkout.PrintShoppingBag();
            Console.WriteLine($"Total Cash Payment: {cashPayment}");
            Console.WriteLine($"Total Change: {change}");

        }


    }
}
