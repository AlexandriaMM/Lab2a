using System;

class Program {
  public static void Main (string[] args) {
    //storing item name from input
    Console.WriteLine ("Enter the name of the item:");
    string item = Console.ReadLine();

    //storing quantity ammount from input
    Console.WriteLine ("Enter the quantity:");
    int quantity = Convert.ToInt32(Console.ReadLine());

    //storing price and determining total
    Console.WriteLine ("Enter the price of the item:");
    double price = Convert.ToDouble(Console.ReadLine());
    double total = quantity * price;
    
   //displaying total in output
    Console.WriteLine ("Total price of " + item + " = " + total);
  }
}