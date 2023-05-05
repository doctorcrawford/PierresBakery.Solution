using System;
// using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Count { get; set; }
    public int Cost {get; set; }

    public Bread (int count)
    {
      Count = count;
      Cost = 5;
    }
  }
}