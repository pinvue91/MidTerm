using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Checkout
    {
        public List<Albums> albums = new List<Albums>() 
        { 
            
        };
        public List<Albums> ShoppingCart { get; set; }
        public static void Start()
        {
            MyLibs.ConsoleLibrary.DrawTitle("Welcome to GC Records");

            while (true)
            {


                if (!MyLibs.UserInputLibrary.UserWantsToContinue("Would you like anything else? We have lots of great stuff", "Invalid entry"))
                {
                    Console.WriteLine("Thanks for shopping with us!");
                }
            }
        }

        public static void PrintCatalogue()
        { 
        
        }

        public static void AddItemToShoppingCart()
        { 
        
        }

        public static void PrintShoppingCart()
        {

        }

        public static void RemoveItemFromShoppingCart()
        { 
        
        }

        public static void PrintReceipt()
        { 
        
        }
    }
}
