using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = Int32.Parse(Console.ReadLine());
            int payment = 100;
            int quarters, nickels, dimes, change;

            // Welcome Message
            Console.WriteLine("Enter the price of the item: ", price);

            // Make sure price is valid
            if (price % 5 != 0 || price < 25)
            {
                Console.WriteLine("Invalid price. Please try again.");
                Console.WriteLine("Enter the price of the item: ", price);
            }

            // Determine Change
            change = payment - price;

            // Determine number of quarters
            quarters = change % 25;
            change -= quarters * 25;

            // Determine number of dimes
            dimes = change % 10;
            change -= dimes * 10;

            // Determine number of nickels
            nickels = change % 5;

            // Display change breakdown 
            Console.WriteLine("You bought an item for " + price +
                "cents and gave me a dollar. Your change is: \n" +
                quarters + " quarters\n" + dimes + " dimes, and\n" +
                nickels + " nickels.");
        }
    }
}
