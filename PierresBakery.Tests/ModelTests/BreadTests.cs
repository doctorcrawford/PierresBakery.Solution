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
      Bread newBread = new Bread(4);
      int expected = 4;
      Assert.AreEqual(expected, newBread.Count);
    }

    [TestMethod]
    public void GetCost_GetsPriceBasedOffAmtOfBread_Int()
    {
      Bread newBread = new Bread(7);
      int expected = 25;
      Assert.AreEqual(expected, newBread.GetCost());
    }
  }
}