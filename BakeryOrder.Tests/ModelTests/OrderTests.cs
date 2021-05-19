using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryOrder.Models;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string oName = "Order";
      string oDescription = "Buy Stuff.";
      string oDate = "Today";
      string oPrice = "Free";
      Order newOrder = new Order(oName, oDescription, oDate, oPrice);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string oName = "Order";
      string oDescription = "Buy Stuff.";
      string oDate = "Today";
      string oPrice = "Free";
      Order newOrder = new Order(oName, oDescription, oDate, oPrice);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(oDescription, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string oName = "Order";
      string oDescription = "Buy Stuff.";
      string oDate = "Today";
      string oPrice = "Free";
      Order newOrder = new Order(oName, oDescription, oDate, oPrice);
      string updatedDescription = "Do other stuff";
      newOrder.OrderDescription = updatedDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedDescription, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> { };

    //   // Act
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Order newOrder1 = new Order(description01);
    //   Order newOrder2 = new Order(description02);
    //   List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //   //Act
    //   List<Order> result = Order.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string oName = "Order";
      string oDescription = "Buy Stuff.";
      string oDate = "Today";
      string oPrice = "Free";
      Order newOrder = new Order(oName, oDescription, oDate, oPrice);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string oName1 = "Order1";
      string oName2 = "Order2";
      string oDescription = "Buy Stuff.";
      string oDate = "Today";
      string oPrice = "Free";
      Order newOrder1 = new Order(oName1, oDescription, oDate, oPrice);
      Order newOrder2 = new Order(oName2, oDescription, oDate, oPrice);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}