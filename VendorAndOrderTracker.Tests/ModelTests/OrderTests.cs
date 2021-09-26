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
            Order newOrder = new Order("test title", "test description", "test price", "test date");
            Assert.AreEqual(typeof (Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_String()
        {
            //Arrange
            string title = "Scone";
            string description = "Customer ordered 10 pieces";
            string price = "2 dollars";
            string date = "2021-09-25";

            //Act
            Order newOrder = new Order(title, description, price, date);
            string result1 = newOrder.Title;
            string result2 = newOrder.Description;
            string result3 = newOrder.Price;
            string result4 = newOrder.Date;

            //Assert
            Assert.AreEqual (title, result1);
            Assert.AreEqual (description, result2);
            Assert.AreEqual (price, result3);
            Assert.AreEqual (date, result4);
        }


        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string title = "Scone";
            string description = "Customer ordered 10 pieces";
            string price = "2 dollars";
            string date = "2021-09-25";
            Order newOrder = new Order(title, description, price, date);

            //Act
            string updatedTitle = "Muffin";
            string updatedDescription = "Customer ordered 12 pieces";
            string updatedPrice = "1 dollar";
            string updatedDate = "2021-09-26";
            newOrder.Title = updatedTitle;
            newOrder.Description = updatedDescription;
            newOrder.Price= updatedPrice;
            newOrder.Date= updatedDate;
            string result1 = newOrder.Title;
            string result2 = newOrder.Description;
            string result3 = newOrder.Price;
            string result4 = newOrder.Date;

            //Assert
            Assert.AreEqual (updatedTitle, result1);
            Assert.AreEqual (updatedDescription, result2);
            Assert.AreEqual (updatedPrice, result3);
            Assert.AreEqual (updatedDate, result4);
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
            string title01 = "Scone";
            string title02 = "Muffin";
            string description01 = "Cutomer ordered 10 pieces";
            string description02 = "Customer ordered 12 pieces";
            string price01 = "2 dollars";
            string price02 = "1 dollars";
            string date01 = "2021-09-25";
            string date02 = "2021-09-26";
            Order newOrder1 = new Order(title01, description01, price01, date01);
            Order newOrder2 = new Order(title02, description02, price02, date02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual (newList, result);
        }
    }
}
