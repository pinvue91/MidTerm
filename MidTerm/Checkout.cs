using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MidTerm
{
    class Checkout
    {
        public static List<Albums> albums = new List<Albums>() 
        { 
            new Albums("Album 1", Genre.Pop, "Band 1", "9/10", 14.50),
            new Albums("Album 2", Genre.Rock, "Band 2", "8/10", 10.00),
            new Albums("Album 3", Genre.Jazz, "Band 3", "7/10", 13.75),
        };

        public static List<ItemOrder> ShoppingBag = new List<ItemOrder>();

        public static List<string> actions = new List<string> { "View Inventory", "Trade In", "Quit" };
        public static void Start()
        { 
            while (true)
            {
                UILibs.ConsoleLibrary.DrawTitle("Welcome to GC Records!");

                if (ShoppingBagHasItems())
                {
                    actions.Insert(2, "Check Out");
                }

                PrintActions(actions);

                int selection = UILibs.UserInputLibrary.GetMenuSelection("What would you like to do? ", actions);

                RunAction(actions, selection);

                if (ShoppingBagHasItems())
                {
                    PrintShoppingBag();
                }

            }
        }

        public static void PrintCatalogue(List<Albums> catalogue)
        {
            UILibs.ConsoleLibrary.DrawSectionHeading("Current Catalogue");

            for (int i = 0; i < catalogue.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {GetRecordInfo(catalogue[i])}");
            }

            Console.WriteLine();
        }

        public static void PrintActions(List<string> actions)
        {
            UILibs.ConsoleLibrary.DrawSectionHeading("Available Actions");

            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine($"{i + 1} {actions[i]}");
            }

            Console.WriteLine();
        }

        public static void RunAction(List<string> actions, int selection)
        {
            if (actions[selection] == "View Inventory")
            {
                AddItemToShoppingCart();
            }
            else if (actions[selection] == "Trade In")
            {
                //TradeIn();
                Console.WriteLine("What're ya selling?!?");
            }
            else if (actions[selection] == "Check Out")
            {
                //CompletePurchase();
                GetPaymentMethod();
            }
            else if (actions[selection] == "Quit")
            {
                Console.WriteLine("Alrighty, see ya next time!");
                Thread.Sleep(2000);
                return;
            }
        }

        public static string GetRecordInfo(Albums record)
        {
            return $"{record.Title} by {record.Description} | ${record.Price}";
        }

        public static void AddItemToShoppingCart()
        {
            Console.Clear();
            PrintCatalogue(albums);

            int itemNum = UILibs.UserInputLibrary.GetMenuSelection("Enter Item Number to add to cart ", albums);
            Console.Clear();

            Console.WriteLine($"You have selected: {GetRecordInfo(albums[itemNum])}");
            int quantity = UILibs.UserInputLibrary.GetIntegerResponse("How many would you like? ", 10);

            if (quantity == 0)
            {
                Console.WriteLine("Changed your mind? Not a problem, happens all the time");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            Console.Clear();
            double totalForSelection = albums[itemNum].Price * quantity;

            Console.WriteLine($"{quantity} copies of {albums[itemNum].Title}, That'll be ${totalForSelection}");

            if (UILibs.UserInputLibrary.GetYesOrNoInput("Are you sure?"))
            {
                ShoppingBag.Add(new ItemOrder(albums[itemNum].Title, quantity, albums[itemNum].Price));
                Console.WriteLine("Great, I've added that to your bag!");
            }
            else 
            {
                Console.WriteLine("Not a problem, let us know if you change your mind.");
            }

            Console.Clear();
            PrintCatalogue(albums);

            if (!UILibs.UserInputLibrary.UserWantsToContinue("Would you like anything else? ", "Invalid entry"))
            {
                Console.Clear();
                return;
            }
        }

        public static void PrintShoppingBag()
        {
            UILibs.ConsoleLibrary.DrawTitle("Here's your current order");
            foreach (ItemOrder order in ShoppingBag)
            {
                Console.WriteLine(order.GetOrderInfo());
            }
            Console.WriteLine();
        }

        public static void CompletePurchase()
        { 
        
        }

        public static void Tradein()
        { 
        
        }

        public static void GetPaymentMethod()
        {
            List<string> options = new List<string> { "Cash", "Credit", "Check" };

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }

            int selection = UILibs.UserInputLibrary.GetMenuSelection("How will you be paying today? ", options);

            Console.WriteLine($"Great, you'll be paying with {options[selection]}");
        }

        public static bool ShoppingBagHasItems()
        {
            if (ShoppingBag.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static void PayWithCheck()
        { 
            
        }

        public static void PayWithCash()
        { 
        
        }

        public static void PayWithCredit()
        { 
        
        }
    }
}
