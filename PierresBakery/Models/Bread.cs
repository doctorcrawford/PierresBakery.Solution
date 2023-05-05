using System;
// using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Count { get; set; }
    public int Price {get; set; }

    public Bread (int count)
    {
      Count = count;
      Price = 5;
    }

    public int GetCost()
    {
      return (Count - (int)(Count / 3)) * Price;
    }
  }
}