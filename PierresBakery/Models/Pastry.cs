using System;
// using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : Item
  {
    public Pastry (int count)
    {
      Count = count;
      Price = 2;
      Deal = 4;
    }
  }
}