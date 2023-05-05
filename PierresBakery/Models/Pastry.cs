using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : Item
  {
    public enum PastryType {
      Croissant,
      Muffin,
      Cookie
    }

    public Pastry(string type, int count)
    {
      Type = type;
      Count = count;
      Price = 2;
      Deal = 4;
    }
  }
}