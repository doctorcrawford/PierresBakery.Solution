using System;

namespace PierresBakery.Models
{
  public class Bread : Item
  {
    public Bread (int count)
    {
      Count = count;
      Price = 5;
      Deal = 3;
    }
  }
}