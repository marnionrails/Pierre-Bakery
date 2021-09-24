using System;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Models {
public class Program 
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.WriteLine("Welcome to Marni's Bakery! Here you can order: \n" +
        "Loaf of Bread: $5 each" +
        "A Pastry: $2 each" +
        "Our SPECIALS!\n" +
        "_____________\n" +
        "Bread: Buy 2, get 1 free!" + "\n" +
        "Pastry: 3 for $5!");
      Console.WriteLine("Are you ready to place your order? Select 'y' or 'n' if you need more time!");

      string answer = Console.ReadLine().ToLower();

      if (answer == "y")  
      {
        StartPurchase();
      }
      else if (answer == "n")
      {
        NotReady();
      }
      else 
      {
        InvalidAnswer();
      }
    double totalCost = Bread.GetBreadTotal() + Pastry.GetPastryTotal();
    Console.WriteLine("Your total is: $" + totalCost);
    Console.WriteLine("Would you like anything else? Select 'y' or 'n'");
    string somethingElse = Console.ReadLine().ToLower();
    if (somethingElse == "y")
    {
      Main();
    }
    else 
    {
    Console.WriteLine("Thank you for shopping with us!");
    } 
    Environment.Exit(0); 
  }
      
    public static void NotReady()
    {
      Console.WriteLine("No rush, take your time!");
    }

    public static void Indecisive()
    {
      Console.WriteLine("Please come back when you decide!");
    }

    public static void InvalidAnswer()
    {
      Console.WriteLine("Your answer is invalid. Let's start over");
      Main();
    }

    public static void StartPurchase()
    {
      Console.WriteLine("Would you like to buy some bread? Please select 'y' or 'n'");
      string breadAnswer = Console.ReadLine().ToLower(); 

      if (breadAnswer == "y")
      {
        Console.WriteLine("How many loaves of bread will you be purchasing?");
        string breadInput = Console.ReadLine();
        int breadNum = Int32.Parse(breadInput);
        Bread newBread = new Bread(breadNum);
        PastryPurchase();
      }
      else if (breadAnswer == "n")
      {
        PastryPurchase();
      }
      else 
      {
        InvalidAnswer();
      }
    }

    

    public static void PastryPurchase()
    {
      Console.WriteLine("Would you like to buy some pastries? Please select 'y' or 'n'");
      string pastryAnswer = Console.ReadLine().ToLower(); 

      if (pastryAnswer == "y")
      {
        Console.WriteLine("How many pastries will you be purchasing?");
        string pastryInput = Console.ReadLine();
        int pastryNum = Int32.Parse(pastryInput);
        Pastry newPastry = new Pastry(pastryNum);
      }
      else if (pastryAnswer == "n")
      {
        Indecisive();
      }
      else 
      {
        InvalidAnswer();
      }
    }       
  }
}

