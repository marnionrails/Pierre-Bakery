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
    public void TestsPastryNumber_MakesSurePastryNumberisInt_True()
    {
      //Arrange
      int pastryNumber = 2;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      int result = newPastry.PastryNumber;

      //Assert
      Assert.AreEqual(result.GetType(), typeof(int));
    }

    [TestMethod]
    public void GetPastryNumber_ReturnsPastrynum_5()
    {
      //Arrange
      int pastryNumber = 5;
      Pastry newPastry = new Pastry(5);

      //Act
      int result = newPastry.PastryNumber;

      //Assert
      Assert.AreEqual(result, pastryNumber);
    }
    [TestMethod]
    public void TestsPastryCost_MakesSureCostisDecimal_double()
    {
      //Arrange
      Pastry newPastry = new Pastry(5);

      //Act
      double result = newPastry.PastryCost;

      //Assert
      Assert.AreEqual(result.GetType(), typeof(double));
    }
    [TestMethod]
    public void GetPastryCost_ReturnPastryCost_2()
    {
      //Arrange
      double pastryCost = 2.0;
      Pastry newPastry = new Pastry(5);

      //Act
      double result = newPastry.PastryCost;

      //Assert
      Assert.AreEqual(result, pastryCost);
    }
    [TestMethod]

    public void TotalPastryCost_ReturnsTotalPastryCost_Double()
    {
      //Arrange
      double pastryCost = 2.0;
      int pastryNumber = 1;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert

      Assert.AreEqual(totalPastryCost, pastryCost);
    }
    [TestMethod]
    public void TotalPastryCost_ReturnsCostOfSinglePastry_2()
    {
      //Arrange
      int pastryNumber = 1;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert
      Assert.AreEqual(2,totalPastryCost);
    }
    [TestMethod]
    public void TotalPastryCost_ReturnsCostOfTwoPastries_4()
    {
      //Arrange
      int pastryNumber = 2;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert
      Assert.AreEqual(4,totalPastryCost);

    }
    [TestMethod]
    public void TotalPastryCost_ReturnsCostOfThreePastries_5()
    {
      //Arrange
      int pastryNumber = 3;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert
      Assert.AreEqual(5, totalPastryCost);
    }
    [TestMethod]
    public void TotalPastryCost_ReturnsCostOfSixPastries_10()
    {
      //Arrange
      int pastryNumber = 6;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert
      Assert.AreEqual(10,totalPastryCost);

    }
    [TestMethod]
    public void TotalPastryCost_ReturnsCostOfFivePastries_9()
    {
      //Arrange
      int pastryNumber = 5;
      Pastry newPastry = new Pastry(pastryNumber);

      //Act
      double totalPastryCost = newPastry.TotalPastryCost();

      //Assert
      Assert.AreEqual(9,totalPastryCost);
    }
  }
}