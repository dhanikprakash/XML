using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XML;

namespace XMLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AsssetSearchShoudReturSearchResult()
        {
            //Arrange
            string searchName = "Test";
            string searchScope = "Video";
            string expectedResult = "TestVideo";
            var assetSearch = new AssetSearch();

            //Act 
            var result = assetSearch.SearchAsset(searchName, searchScope);

            //Assert
            Assert.AreEqual(expectedResult, result);




        }
    }
}
