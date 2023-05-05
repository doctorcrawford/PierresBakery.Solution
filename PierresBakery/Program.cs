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
      Console.WriteLine("");
      Console.WriteLine("Would you like to purchase any bread? (y/n)");
      Console.WriteLine("Type 'y' to proceed to bread selection");
      Console.WriteLine("Type 'n' to move onto our pastries");
    }
  }
}