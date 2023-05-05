using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// using System.Linq;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryWithCount_Int()
    {
      Pastry newPastry = new Pastry("Croissant", 7);
      int expected = 7;
      Assert.AreEqual(expected, newPastry.Count);
    }

    [TestMethod]
    public void GetCost_GetsPriceBasedOffAmtOfPastry_Int()
    {
      Pastry newPastry = new Pastry("Croissant", 7);
      int expected = 12;
      Assert.AreEqual(expected, newPastry.GetCost());
    }

    [TestMethod]
    public void GetType_GetsTypeOfPastryType_String()
    {
      Bread newPastry = new Bread("Croissant", 7);
      string expected = "Croissant";
      Assert.AreEqual(expected, newPastry.Type);
    }

    [TestMethod]
    public void PastryType_GetsPastryTypeFromEnum_String()
    {
      string expected = "Muffin";
      Assert.AreEqual(expected, Enum.GetName(typeof(Pastry.PastryType), 1));
    }
  }
}
