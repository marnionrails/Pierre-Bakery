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
  }
}