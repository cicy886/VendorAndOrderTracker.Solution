using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
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
            Order newOrder = new Order("test");
            Assert.AreEqual(typeof (Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_String()
        {
            //Arrange
            string description = "Scone";

            //Act
            Order newOrder = new Order(description);
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual (description, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Scone";

            //Act
            Order newOrder = new Order(description);
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual (description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Scone";
            Order newOrder = new Order(description);

            //Act
            string updatedDescription = "Muffin";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual (updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            // Arrange
            List<Order> newList = new List<Order> { };

            // Act
            List<Order> result = Order.GetAll();

            // Assert
            CollectionAssert.AreEqual (newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            //Arrange
            string description01 = "Scone";
            string description02 = "Muffin";
            Order newOrder1 = new Order(description01);
            Order newOrder2 = new Order(description02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual (newList, result);
        }
    }
}
