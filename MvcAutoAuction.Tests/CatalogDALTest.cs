﻿using MvcAutoAuction.dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using MvcAutoAuction.Models;
using System.Collections.Generic;

namespace MvcAutoAuction.Tests
{
    
    
    /// <summary>
    ///This is a test class for CatalogDALTest and is intended
    ///to contain all CatalogDALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CatalogDALTest
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
        ///A test for BrandsToList
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.        
        // [HostType("ASP.NET")]
        // [AspNetDevelopmentServerHost("C:\\Users\\cezar\\MvcAA\\MvcAutoAuction1\\MvcAutoAuction", "/")]
        [TestMethod()]
        public void CatalogDALConstructorTest()
        {
            CatalogDAL target = new CatalogDAL();
            // Assert.Inconclusive("TODO: Implement code to verify target");
        }


        public void BrandsToListTest()
        {
            CatalogDAL target = new CatalogDAL(); // TODO: Initialize to an appropriate value
            // List<Brand> expected = null; // TODO: Initialize to an appropriate value
            List<Brand> actual;
            actual = target.BrandsToList();
            Assert.IsNotNull(actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
