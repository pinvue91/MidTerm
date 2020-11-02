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
          
        };

        public static List<ItemOrder> ShoppingBag = new List<ItemOrder>();

        public static List<string> actions = new List<string> { "View Inventory", "Trade In", "Quit" };
        public static void Start()
        { 
            while (true)
            {
                UILibs.ConsoleLibrary.DrawTitle("Thanks for shopping GC Records!");

                if (ShoppingBagHasItems())
                {
                    if (actions[2] != "Check Out")
                    {
                        actions.Insert(2, "Check Out");
                    }
                }

                if (ShoppingBagHasItems())
                {
                    PrintShoppingBag();
                }

                PrintActions(actions);

                int selection = UILibs.UserInputLibrary.GetMenuSelection("What would you like to do? ", actions);

                RunAction(actions, selection);
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
            string action = actions[selection];
            if (action == "View Inventory")
            {
                AddItemToShoppingCart();
            }
            else if (action == "Trade In")
            {
                TradeIn();
            }
            else if (action == "Check Out")
            {
                CompletePurchase();
            }
            else if (action == "Quit")
            {
                CustomerQuit();
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
                AddItemToShoppingCart();
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
            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your current order");
            foreach (ItemOrder order in ShoppingBag)
            {
                Console.WriteLine(order.GetOrderInfo());
            }
            Console.WriteLine();
        }

        public static void CompletePurchase()
        {
            Console.Clear();
            PrintShoppingBag();
            GetPaymentMethod();
        }

        public static void TradeIn()
        {
            Console.Clear();
            UILibs.ConsoleLibrary.DrawSectionHeading("What're ya selling?!?");

            string title = UILibs.UserInputLibrary.GetUserResponse("What's the name of your album? ");
            string artist = UILibs.UserInputLibrary.GetUserResponse("What's the name the artist? ");
            //string genre = UILibs.UserInputLibrary.GetUserResponse("What's the genre of this album? ");
            string review = UILibs.UserInputLibrary.GetUserResponse("What rating would you give this album? ");

            Console.WriteLine($"Alright, {title} by {artist}...I can give you about $3.50");
            albums.Add(new Albums(title, Genre.Rock, artist, review, 12));
            Console.Clear();
        }

        public static void CustomerQuit()
        {
            Console.WriteLine("Alright, see you next time");
            ShoppingBag = new List<ItemOrder>();
            actions.RemoveAt(2);
            Thread.Sleep(1500);
            Console.Clear();
        }

        public static void GetGenre(Genre genre)
        {
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($" {i}");
            }
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

            if (options[selection] == "Cash")
            {

            }
            else if (options[selection] == "Credit")
            {

            }
            else
            {
                PayWithCheck();
            }
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
            string checkNum = UILibs.UserInputLibrary.GetCheckNumber("Enter your 8 digit check number");
            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your receipt.");
            PrintShoppingBag();
            Console.WriteLine($"Paid with check #: {checkNum}");
        }
    }
}
