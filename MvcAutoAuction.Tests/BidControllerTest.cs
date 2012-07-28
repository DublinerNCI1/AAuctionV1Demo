using MvcAutoAuction.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using MvcAutoAuction.Models;

namespace MvcAutoAuction.Tests
{

    [TestClass]
    public class BidControllerTest
    {
        [TestMethod]
        public void BiddingForm()
        {
            // Arrange
            BidController controller = new BidController();

            // Act
            ActionResult result = controller.BiddingForm() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }        
    }
}
