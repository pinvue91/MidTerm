using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MidTerm
{
    class Checkout
    {
        public List<Album> Albums { get; set; }

        public static List<ItemOrder> ShoppingBag = new List<ItemOrder>();

        public static List<string> actions = new List<string> { "View Inventory", "Trade In", "Quit" };

        public Checkout(List<Album> Albums) 
        {
            this.Albums = Albums;
        }

        public void Start()
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

        public void RunAction(List<string> actions, int selection)
        {
            string action = actions[selection];
            if (action == "View Inventory")
            {
                AddItemToShoppingCart();
            }
            else if (action == "Trade In")
            {
                TradeIn.TradeInAlbum();
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

        public void AddItemToShoppingCart()
        {
            while (true)
            {
                Console.Clear();
                PrintCatalogue(Albums);

                int itemNum = UILibs.UserInputLibrary.GetMenuSelection("Enter Item Number to add to cart ", Albums);
                Console.Clear();

                Console.WriteLine($"You have selected: {GetRecordInfo(Albums[itemNum])}");
                int quantity = UILibs.UserInputLibrary.GetIntegerResponse("How many would you like? Enter 0 if you've changed your mind ", 100);

                if (quantity == 0)
                {
                    Console.WriteLine("Changed your mind? Not a problem, happens all the time");
                    Thread.Sleep(1500);
                    AddItemToShoppingCart();
                }

                Console.Clear();
                double albumPrice = double.Parse(Albums[itemNum].Price);
                double totalForSelection = albumPrice * quantity;

                Console.WriteLine($"{quantity} copies of {Albums[itemNum].Title}, That'll be ${totalForSelection}");

                if (UILibs.UserInputLibrary.GetYesOrNoInput("Are you sure? "))
                {
                    ShoppingBag.Add(new ItemOrder(Albums[itemNum].Title, quantity, albumPrice));
                    Console.WriteLine("Great, I've added that to your bag!");
                }
                else
                {
                    Console.WriteLine("Not a problem, let us know if you change your mind.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                if (!UILibs.UserInputLibrary.UserWantsToContinue("Would you like anything else? ", "Invalid entry"))
                {
                    Console.Clear();
                    break;
                }
            }
        }

        public void PrintCatalogue(List<Album> catalogue)
        {
            UILibs.ConsoleLibrary.DrawSectionHeading("Current Catalogue");

            for (int i = 0; i < catalogue.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {GetRecordInfo(catalogue[i])}");
            }

            Console.WriteLine();
        }

        public static void CompletePurchase()
        {
            Console.Clear();
            PrintShoppingBag();
            GetPaymentMethod();
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

        public string GetRecordInfo(Album record)
        {
            return $"{record.Title} by {record.Artist} | ${record.Price}";
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
                Cash.PayWithCash(CalculateTotalWithTax());
            }
            else if (options[selection] == "Credit")
            {
                CreditCard.PayWithCredit();
            }
            else
            {
                Check.PayWithCheck();
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

        public static void PrintShoppingBag()
        {
            double subtotal = GetOrderTotal(ShoppingBag);
            double taxRate = 0.06;
            double taxToCollect; ;

            UILibs.ConsoleLibrary.DrawSectionHeading("Here's your current order");

            foreach (ItemOrder item in ShoppingBag)
            {
                Console.WriteLine($"{item.ItemName} x {item.Quantity} = {item.OrderTotal}");
            }

            Console.WriteLine();
            Console.WriteLine($"Subtotal:  \t{subtotal}");
            taxToCollect = subtotal * taxRate;
            Console.WriteLine($"Sales Tax: \t{(taxToCollect):00.00}");
            Console.WriteLine($"Total:     \t{subtotal + taxToCollect:0.00}");
            Console.WriteLine();
        }

        public static void PrintReceipt()
        {
            double subtotal = GetOrderTotal(ShoppingBag);
            double taxDue = CalculateTaxDue();;

            UILibs.ConsoleLibrary.DrawSectionHeading("Purchase Receipt");

            foreach (ItemOrder item in ShoppingBag)
            {
                Console.WriteLine($"{item.ItemName} x {item.Quantity} = {item.OrderTotal}");
            }

            Console.WriteLine();
            Console.WriteLine($"Subtotal:  \t{subtotal}");
            Console.WriteLine($"Sales Tax: \t{(taxDue):0.00}");
            Console.WriteLine($"Total:     \t{CalculateTotalWithTax():0.00}");
            Console.WriteLine();
        }

        public static double GetOrderTotal(List<ItemOrder> shoppingBag)
        {
            double total = 0;

            foreach (ItemOrder order in ShoppingBag)
            {
                total += order.OrderTotal;
            }

            return total;
        }

        public static double CalculateTotalWithTax()
        {
            return GetOrderTotal(ShoppingBag) + CalculateTaxDue();
        }

        public static double CalculateTaxDue()
        {
            return GetOrderTotal(ShoppingBag) * .06;
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
    }
}
