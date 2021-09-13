using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
     [TestMethod]
    public void TestsBreadNumber_MakesSureBreadNumberisInt_True()
    {
      //Arrange
      int pastryNumber = 2;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      int result = newPastry.PastryNumber;

      //Assert
      Assert.AreEqual(result.GetType(), typeof(string));
    }
  }
}