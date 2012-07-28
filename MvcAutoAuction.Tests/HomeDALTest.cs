using MvcAutoAuction.dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using MvcAutoAuction.Models;
using System.Collections.Generic;

namespace MvcAutoAuction.Tests
{
    
    
    /// <summary>
    ///This is a test class for HomeDALTest and is intended
    ///to contain all HomeDALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HomeDALTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        


        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetTopSellingCars
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]        
        public void HomeDALConstructorTest()
        {
            HomeDAL target = new HomeDAL();
           // Assert.Inconclusive("TODO: Implement code to verify target");
        }

        public void GetTopSellingCarsTest()
        {
            HomeDAL target = new HomeDAL(); // TODO: Initialize to an appropriate value
            int count = 5; // TODO: Initialize to an appropriate value
            // List<Car> expected = null; // TODO: Initialize to an appropriate value
            List<Car> actual;
            actual = target.GetTopSellingCars(count);
            Assert.IsNotNull(actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
