using System;

namespace PierresBakery.Models
{
  public abstract class Item
  {
    public int Count { get; set; }
    public int Price { get; set; }
    public int Deal { get; set; }

    public int GetCost()
    {
      return (Count - (int)(Count / Deal)) * Price;
    }
  }
}