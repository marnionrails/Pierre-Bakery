using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void TestsBreadNumber_MakesSureBreadNumberisInt_True()
    {
      //Arrange
      int breadNumber = 2;
      Bread newBread = new Bread(breadNumber);

      //Act
      int result = newBread.BreadNumber;

      //Assert
      Assert.AreEqual(result.GetType(), typeof(int));
    }
    [TestMethod]
    public void GetBreadNumber_ReturnsBreadNumber_5()
    {
      //Arrange
      int breadNumber = 5;
      Bread newBread = new Bread(5);

      //Act
      int result = newBread.BreadNumber;

      //Assert
      Assert.AreEqual(result, breadNumber);
    }
    [TestMethod]
    public void TestsBreadCost_MakesSureCostisDecimal_double()
    {
      //Arrange
      double breadCost = 2.0;
      Bread newBread = new Bread(5);

      //Act
      double result = newBread.BreadCost;

      //Assert
      Assert.AreEqual(result.GetType(), typeof(double));
    }
  }
}