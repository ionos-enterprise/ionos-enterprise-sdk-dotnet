using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Model;
using Client;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class RequestApiTest
    {
        RequestApi reqApi = new RequestApi(Config.Configuration);
        static Request request;
        static string instanceType = "request";

        [TestMethod]
        public void RequestList()
        {
            var requests = reqApi.List();
            Assert.IsTrue(requests.Items.Count > 0);
            Assert.AreEqual(instanceType, requests.Items[0].Type);
            request = requests.Items[0];
        }

        [TestMethod]
        public void RequestGet()
        {
            Request req = reqApi.Get(request.Id);
            Assert.AreEqual(request.Id, req.Id);
            Assert.AreEqual(instanceType, req.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void RequestGetFail()
        {
            try
            {
                reqApi.Get("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void RequestStatusGet()
        {
            RequestStatus req = reqApi.GetStatus(request.Id);
            Assert.AreEqual(request.Id, req.Id.Split('/')[0]);
            Assert.AreEqual("request-status", req.Type);
        }
    }
}
