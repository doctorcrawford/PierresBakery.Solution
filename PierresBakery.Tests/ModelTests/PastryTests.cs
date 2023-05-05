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
      Pastry newPastry = new Pastry(7);
      int expected = 7;
      Assert.AreEqual(expected, newPastry.Count);
    }

    [TestMethod]
    public void GetCost_GetsPriceBasedOffAmtOfPastry_Int()
    {
      Pastry newPastry = new Pastry(7);
      int expected = 12;
      Assert.AreEqual(expected, newPastry.GetCost());
    }
  }
}