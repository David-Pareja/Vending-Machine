using System;
using System.ComponentModel.Design;

namespace VendingMachine_Project
{
    class Program
    {
        public static float price = 2.5f;
        static void Main(string[] args)
        {
            DrawAsciiArt();

            ChooseMenu();

            TakeInMoney();
            Console.ReadKey();
        }

        static void ChooseMenu()
        {
            float meatSnackPrice = 3.00f;
            float sodaPrice = 2.50f;
            float chipsPrice = 1f;
            float cookiesPrice = 2f;
            float skittlesPrice = 1.50f;
            float cheetosPrice = 1.75f;

            Console.WriteLine("Beef Jerky: $" + meatSnackPrice.ToString("N2"));
            Console.WriteLine("Soda: $" + sodaPrice.ToString("N2"));
            Console.WriteLine("Chips: $" + chipsPrice.ToString("N2"));
            Console.WriteLine("Cookies: $" + cookiesPrice.ToString("N2"));
            Console.WriteLine("Skittles: $" + skittlesPrice.ToString("N2"));
            Console.WriteLine("Cheetos: $" + cheetosPrice.ToString("N2"));
            Console.WriteLine("Please select an item");

            string itemChoice = Console.ReadLine().ToLower();

            switch (itemChoice)
            {
                case "beef jerky":
                case "beef":
                case "jerky":
                    price = meatSnackPrice;
                    break;
                case "soda":
                    price = sodaPrice;
                    break;
                case "chips":
                case "chip":
                    price = chipsPrice;
                    break;
                case "cookies":
                case "cookie":
                case "cooky":
                    price = cookiesPrice;
                    break;
                case "skittles":
                case "skitles":
                case "skitle":
                    price = skittlesPrice;
                    break;
                case "cheeto":
                case "cheetos":
                    price = cheetosPrice;
                    break;
                default:
                    price = 0;
                    Console.WriteLine("Not an option, choose again!");
                    break;
            }
            Console.WriteLine("Your total is $" + price.ToString("N2"));
        }
        static void TakeInMoney()
        {
            Console.WriteLine("Please insert cash");
            float inputAmount = 0;
            while (inputAmount < price)
            {
                float.TryParse(Console.ReadLine(), out inputAmount);
                if (inputAmount >= price)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not enough money, please enter a new amount");
                }
            }
            float change = inputAmount - price;
            MakeChange(change);
        }

        static void MakeChange(float totalChange)
        {
            int dollars = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            Console.WriteLine("Your change is " + totalChange.ToString("N2"));
            while (totalChange >= 1)
            {
                dollars++;
                totalChange -= 1;
            }
            while (totalChange >= 0.25f)
            {
                quarters++;
                totalChange -= 0.25f;
            }
            while (totalChange >= 0.1f)
            {
                dimes++;
                totalChange -= 0.1f;
            }
            while (totalChange >= 0.05f)
            {
                nickels++;
                totalChange -= 0.05f;
            }
            while (totalChange >= 0.01f)
            {
                pennies++;
                totalChange -= 0.01f;
            }
            Console.WriteLine("return " + dollars + " dollars, " + quarters + " quarters, " + dimes + " dimes, " + nickels + " nickels, " + pennies + " pennies ");
        }
            static void DrawAsciiArt()
            {
                Console.WriteLine("");
                Console.WriteLine("=========================");
                Console.WriteLine("[]   VENDING MACHINE   []");
                Console.WriteLine("[]   BY DAVID PAREJA   []");
                Console.WriteLine("[]  -----------------  []");
                Console.WriteLine("[]  [ 1 ] [ 2 ] [ 3 ]  []");
                Console.WriteLine("[]  [ 4 ] [ 5 ] [ 6 ]  []");
                Console.WriteLine("[]  [ 7 ] [ 8 ] [ 9 ]  []");
                Console.WriteLine("[]        [ 0 ]        []");
                Console.WriteLine("=========================");
                Console.WriteLine("");
            }
        }
    }