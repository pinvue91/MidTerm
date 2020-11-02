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
        public static void PayWithCash(double totalPrice)
        {
            bool enoughCash = false;

            Console.WriteLine("Please enter your total cash payment: ");

            int cashPayment = int.Parse(Console.ReadLine());

            double change = cashPayment - totalPrice;

            while (enoughCash == false)
            {
                change = cashPayment - totalPrice;
                if (change >=0)
                {
                    enoughCash = true;
                }
                
                
                if (change < 0)
                {
                    Console.WriteLine($"That's not enough. The total is {totalPrice:0.00}. Please enter your total cash payment: ");
                    cashPayment = int.Parse(Console.ReadLine());
                }
            }



            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            Checkout.PrintReceipt();
            Console.WriteLine($"Total Cash Payment: {cashPayment}");
            Console.WriteLine($"Total Change: {change:0.00}");
            Thread.Sleep(5000);

            Console.Clear();
            Checkout.ShoppingBag = new List<ItemOrder>();
            Checkout.actions.RemoveAt(2);
        }


    }
}
