﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcAutoAuction;
using MvcAutoAuction.Controllers;

namespace MvcAutoAuction.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ActionResult result = controller.Index() as ActionResult;

            // Assert
            Assert.AreEqual("ASP.NET MVC MotorBid Auto Auction Site", result.ViewBag.Title);
        }
    }
}
