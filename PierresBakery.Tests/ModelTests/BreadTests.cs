using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;
// using System.Linq;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithCount_Int()
    {
      Bread newBread = new Bread("Challah", 4);
      int expected = 4;
      Assert.AreEqual(expected, newBread.Count);
    }

    [TestMethod]
    public void GetCost_GetsPriceBasedOffAmtOfBread_Int()
    {
      Bread newBread = new Bread("Challah", 7);
      int expected = 25;
      Assert.AreEqual(expected, newBread.GetCost());
    }

    [TestMethod]
    public void FindType_LooksForBreadType_String()
    {
      string expected = "Challah";
      Assert.AreEqual(expected, Bread.BreadTypes[1]);
    }

    [TestMethod]
    public void GetType_GetsTypeOfBreadType_String()
    {
      Bread newBread = new Bread("Challah", 7);
      string expected = "Challah";
      Assert.AreEqual(expected, newBread.Type);
    }
  }
}