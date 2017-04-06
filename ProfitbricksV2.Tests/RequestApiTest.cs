using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Model;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class RequestApiTest
    {

        RequestApi reqApi = new RequestApi(Config.Configuration);
        static Request request;

        [TestMethod]
        public void ListGetRequests()
        {
            var requests = reqApi.List();
            Assert.IsTrue(requests.Items.Count > 0);
            request = requests.Items[0];

            Request req = reqApi.Get(request.Id);

            Assert.AreEqual(request.Id, req.Id);

        }

        [TestMethod]
        public void GetRequestStatus()
        {
            var requests = reqApi.List();
            Assert.IsTrue(requests.Items.Count > 0);
            request = requests.Items[0];
            RequestStatus req = reqApi.GetStatus(request.Id);

            Assert.AreEqual(request.Id, req.Id.Split('/')[0]);
        }
    }
}
