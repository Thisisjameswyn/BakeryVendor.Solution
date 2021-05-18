// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using BakeryOrder.Models;
// using System;

// namespace ToDoList.Tests
// {
//   [TestClass]
//   public class ItemTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Order.ClearAll();
//     }

//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Order newItem = new Order("test");
//       Assert.AreEqual(typeof(Order), newItem.GetType());
//     }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       //Arrange
//       string description = "Walk the dog.";

//       //Act
//       Order newOrder = new Order(description);
//       string result = newOrder.OrderDescription;

//       //Assert
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
//     public void SetDescription_SetDescription_String()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Order newOrder = new Order(description);

//       //Act
//       string updatedDescription = "Do the dishes";
//       newOrder.Description = updatedDescription;
//       string result = newOrder.Description;

//       //Assert
//       Assert.AreEqual(updatedDescription, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       // Arrange
//       List<Order> newList = new List<Order> { };

//       // Act
//       List<Order> result = Order.GetAll();

//       // Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsItems_ItemList()
//     {
//       //Arrange
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Order newOrder1 = new Order(description01);
//       Order newOrder2 = new Order(description02);
//       List<Order> newList = new List<Order> { newOrder1, newOrder2 };

//       //Act
//       List<Order> result = Order.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Order newOrder = new Order(description);

//       //Act
//       int result = newOrder.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectItem_Item()
//     {
//       //Arrange
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Order newOrder1 = new Order(description01);
//       Order newOrder2 = new Order(description02);

//       //Act
//       Order result = Order.Find(2);

//       //Assert
//       Assert.AreEqual(newOrder2, result);
//     }
//   }
// }