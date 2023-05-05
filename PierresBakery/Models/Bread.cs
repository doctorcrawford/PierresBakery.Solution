using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread : Item
  {
    public enum BreadType {
      Sourdough,
      Challah,
      Baguette
    }

    public Bread (string type, int count)
    {
      Type = type;
      Count = count;
      Price = 5;
      Deal = 3;
    }
  }
}