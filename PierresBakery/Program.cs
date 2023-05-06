using System;
using PierresBakery.Models;
using PierresBakery.UserInterfaceModels;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      BakeryRun();
    }

    private static void BakeryRun()
    {
      PrintWelcomeMessage();

      string buyBread = YesOrNo();
      string breadType = "";
      int breadCount = 0;

      if (buyBread == "y")
      {
        Console.WriteLine("First of, here are our bread options:");
        ListTypes<Bread.BreadType>();
        Console.WriteLine("Which bread type would you like?");
        breadType = SafeGetType<Bread.BreadType>();
        Console.WriteLine("In case you didn't already know, we have a special for bread:");
        Console.WriteLine("Buy 2, get one free!");
        Console.WriteLine($"How many {breadType} loaves would you like?");
        breadCount = SafeGetNum();
      }

      Bread userBread = new Bread(breadType, breadCount);

      Console.WriteLine("Now onto the pastries...");
      Console.WriteLine("Would you like to purchase any pastries? (y/n)");
      Console.WriteLine("Type 'y' to proceed to pastry selection");
      Console.WriteLine("Type 'n' to tally up your total");

      string buyPastries = YesOrNo();
      string pastryType = "";
      int pastryCount = 0;

      if (buyPastries == "y")
      {
        Console.WriteLine("First of, here are our pastry options:");
        ListTypes<Pastry.PastryType>();
        Console.WriteLine("Which pastry type would you like?");
        pastryType = SafeGetType<Pastry.PastryType>();
        Console.WriteLine("In case you didn't already know, we have a special for pastries:");
        Console.WriteLine("Buy 3, get one free!");
        Console.WriteLine($"How many {pastryType}s would you like?");
        pastryCount = SafeGetNum();
      }

      Pastry userPastry = new Pastry(pastryType, pastryCount);

      int breadCost = userBread.GetCost();
      int pastryCost = userPastry.GetCost();

      Console.WriteLine("Ok let's tally up your total!");
      Console.WriteLine($"You bought {userBread.Count} loaf(ves) of {userBread.Type} bread.");
      Console.WriteLine($"Bread total: ${breadCost}");
      Console.WriteLine($"You bought {userPastry.Count} {userPastry.Type}(s).");
      Console.WriteLine($"Pastry total: ${pastryCost}");
      Console.WriteLine($"Total Cost: ${breadCost + pastryCost}");

    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("We have a mix of various types of bread and pastries for you to purchase.");
      Console.WriteLine("Would you like to purchase any bread? (y/n)");
      Console.WriteLine("Type 'y' to proceed to bread selection");
      Console.WriteLine("Type 'n' to move onto our pastries");
    }

    private static void ListTypes<T>() where T : struct, Enum
    {
      foreach (string type in Enum.GetNames<T>())
      {
        Console.WriteLine(type);
      }
    }

    private static string YesOrNo()
    {
      string input = Console.ReadLine();
      if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
      {
        Console.WriteLine("Sounds good!");
        return "y";
      }
      else if (input.Equals("n", StringComparison.InvariantCultureIgnoreCase))
      {
        Console.WriteLine("No worries, mate!");
        return "";
      }
      else
      {
        Console.WriteLine("Please enter a valid input (y/n)");
        YesOrNo();
        return "";
      }
    }

    private static int SafeGetNum()
    {
      string input = Console.ReadLine();

      if (int.TryParse(input, out int inputNum))
      {
        return inputNum;
      }
      else
      {
        Console.WriteLine("Please enter a valid option");
        SafeGetNum();
        return 0;
      }
    }

    private static string SafeGetType<T>() where T : struct, Enum
    {
      string userInput = Console.ReadLine();
      bool success = Enum.TryParse<T>(userInput, true, out T output);
      if (success)
      {
        return output.ToString();
      }
      else
      {
        Console.WriteLine("Please enter a valid type");
        ListTypes<T>();
        SafeGetType<T>();
        return "";
      }
    }
  }
}