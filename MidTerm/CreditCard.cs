using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

            //CC Number

            Console.WriteLine("Enter your 16 digit credit card number (no dashes or spaces): ");

            string creditCardNum = Console.ReadLine();

            bool validCCnumber = CCNumberValidation(creditCardNum);

            while(validCCnumber == false)
            {
                Console.WriteLine("Invalid credit card number!\nPlease enter a 16 digit credit card number (no dashes or spaces):");
                creditCardNum = Console.ReadLine();
                validCCnumber = CCNumberValidation(creditCardNum);
            }

            //Expiration Date

            Console.WriteLine("Enter your card expiration date (mm/yy): ");
            string expirationDate = Console.ReadLine();

            bool validExpDate = ExpDateValidation(expirationDate);

            while (validExpDate == false)
            {
                Console.WriteLine("Invalid expiration date!\nPlease enter your card expiration date (mm/yy):");
                expirationDate = Console.ReadLine();
                validExpDate = ExpDateValidation(expirationDate);
            }

            //CW

            Console.WriteLine("Enter your 3 digit card CW: ");
            string cw = Console.ReadLine();

            bool validCW = CWValidation(cw);

            while (validCW == false)
            {
                Console.WriteLine("Invalid CW!\nPlease enter your card's 3 digit CW: ");
                cw = Console.ReadLine();
                validCW = CWValidation(cw);
            }


            Console.WriteLine($"Ok, everything looks good here. ");
            Thread.Sleep(1000);
            Console.Clear();

            //UILibs.ConsoleLibrary.DrawSectionHeading("Here's your receipt.");
            //Checkout.PrintShoppingBag();
            Console.WriteLine($"Paid with credit card#: {creditCardNum}\nExpiration Date: {expirationDate}\nCW: {cw}");
            Thread.Sleep(1500);
            Console.Clear();

        }

        public static bool CCNumberValidation(string input)
        {
            string pattern = @"^[1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9][1-9]$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ExpDateValidation(string input)
        {
            string pattern = @"(0[1-9]|10|11|12)/[0-9]{2}$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CWValidation(string input)
        {
            string pattern = @"^[1-9][1-9][1-9]$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
