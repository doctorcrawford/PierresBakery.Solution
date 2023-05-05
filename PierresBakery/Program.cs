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
      YesOrNo();
      // SafeGet();
      // string breadType = SafeGetBreadType();
    }

    private static void ListTypes()
    {
      foreach (string type in Enum.GetNames(typeof(Bread.BreadType)))
      {
        Console.WriteLine($"{type}");
      }
    }

    private static void YesOrNo()
    {
      string input = Console.ReadLine();
      if (input == "y" || input == "Y")
      {
        BreadOptions();
      }
      else if (input == "n" || input == "N")
      {
        PastryOptions();
        YesOrNo();
      }
    }
  }

  private static void BreadOptions()
  {

  }

  private static void PastryOptions()
  {

  }

  // private static string SafeGet()
  // {
  //   string input = Console.ReadLine();
  //   if (int.TryParse(input, true, out string result))
  //   {
  //     return 
  //   }
  // }

  // private static string SafeGetBreadType()
  // {
  //   string userInput = Console.ReadLine();
  //   bool success = Enum.TryParse<Bread.BreadType>(userInput, true, out Bread.BreadType output);
  //   if (success)
  //   {
  //     return output.ToString();
  //   }
  //   else
  //   {
  //     return "Please enter a valid type";
  //     SafeGetBreadType();
  //   }
  // }
}
}