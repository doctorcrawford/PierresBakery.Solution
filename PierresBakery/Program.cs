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
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("We have a mix of various types of bread and pastries for you to purchase.");
      Console.WriteLine("First of, here are our bread options:");
      ListTypes();
      Console.WriteLine("Would you like to purchase any bread? (y/n)");
      Console.WriteLine("Type 'y' to proceed to bread selection");
      Console.WriteLine("Type 'n' to move onto our pastries");
      string buyBread = YesOrNo();
      if (buyBread == "y")
      {
        Console.WriteLine("Which bread type would you like?");
        string breadType = SafeGetBreadType();
        Console.WriteLine("In case you didn't already know, we have a special for bread:");
        Console.WriteLine("Buy 2, get one");
        Console.WriteLine($"How many {breadType} loaves would you like?");
        int breadCount = SafeGetNum();
        Bread userBread = new Bread(breadType, breadCount);
      }
      Console.WriteLine("Now onto the pastries...");
      Console.WriteLine("Would you like to purchase any pastries? (y/n)");
      Console.WriteLine("Type 'y' to proceed to pastry selection");
      Console.WriteLine("Type 'n' to tally up your total");
      string buyPastries = YesOrNo();
      if (buyPastries == "y")
      {
        Console.WriteLine("Which pastry type would you like?");
        string pastryType = SafeGetBreadType();
        Console.WriteLine("In case you didn't already know, we have a special for pastries:");
        Console.WriteLine("Buy 3, get one");
        Console.WriteLine($"How many {pastryType}s would you like?");
        int pastryCount = SafeGetNum();
        Pastry userPastry = new Pastry(pastryType, pastryCount);
      }


    }

    private static void ListTypes()
    {
      foreach (string type in Enum.GetNames(typeof(Bread.BreadType)))
      {
        Console.WriteLine($"{type}");
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
      }
    }


    // private static void BreadOptions()
    // {

    // }

    // private static void PastryOptions()
    // {

    // }

    private static string SafeGetNum()
    {
      string input = Console.ReadLine();
      if (int.TryParse(input, out int inputNum))
      {
        return inputNum;
      }
      else
      {
        Console.WriteLine("Please enter a valid option");
        SafeGet();
        return 0;
      }
    }

    private static string SafeGetBreadType()
    {
      string userInput = Console.ReadLine();
      bool success = Enum.TryParse<Bread.BreadType>(userInput, true, out Bread.BreadType output);
      if (success)
      {
        return output.ToString();
      }
      else
      {
        Console.WriteLine("Please enter a valid type");
        SafeGetBreadType();
        return "";
      }
    }

  }
}