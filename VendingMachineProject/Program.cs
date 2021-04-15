// Excercise 03
//Author: Jensen, Luke

using Can;
using System;

namespace Exercise03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the Vending Machine!");
            Console.Write("Please insert {0:c}:  ", sodaPrice.priceDecimal);
            decimal amountInserted2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0:c}", amountInserted2);
            sodaRack.RemoveACanOf(Flavor.REGULAR);
            Console.WriteLine("Here is the soda!");
        }

    }
}