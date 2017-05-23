using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Model;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class LocationApiTest
    {
        LocationApi locApi = new LocationApi(Config.Configuration);
        static Location location;

        [TestMethod]
        public void ListAllLocations()
        {
            var locations = locApi.FindAll();
            Assert.IsTrue(locations.Items.Count > 0);

            location = locations.Items[0];

            Location loc = locApi.FindById(location.Id);
            Assert.AreEqual(location.Id, loc.Id);
        }
    }
}
