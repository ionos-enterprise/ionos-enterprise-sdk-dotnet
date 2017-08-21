using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Model;
using Client;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class LocationApiTest
    {
        LocationApi locApi = new LocationApi(Config.Configuration);

        [TestMethod]
        public void LocationList()
        {
            var locations = locApi.FindAll();
            Assert.IsTrue(locations.Items.Count > 0);

            string locId = "";
            foreach (var item in locations.Items)
            {
                Assert.AreEqual(item.Type, "location");
                if (item.Id == "us/las")
                    locId = item.Id;
            }

            Assert.AreEqual(locId, "us/las");
        }

        [TestMethod]
        public void LocationGet()
        {
            Location loc = locApi.FindById("us/las");
            Assert.AreEqual(loc.Id, "us/las");
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void LocationGetFail()
        {
            try
            {
                locApi.FindById("us/00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains("Resource does not exist"));
                throw;
            }
        }
    }
}
