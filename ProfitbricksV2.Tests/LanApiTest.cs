using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Client;
using Api;
using Model;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class LanApiTest
    {
        Configuration configuration;
        DataCenterApi dcApi;
        LanApi lanApi;
        static Datacenter datacenter;
        static Lan lan;


        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",

            };

            dcApi = new DataCenterApi(configuration);

            lanApi = new LanApi(configuration);

            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/lasdev"
                    }
                };

                datacenter = dcApi.Create(datacenter);
            }
        }

        [TestMethod]
        public void LanCreate()
        {
            Configure();
            lan = new Lan { Properties = new LanProperties { Public = true, Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString() } };

            lan = lanApi.Create(datacenter.Id, lan);
            DoWait(lan.Request);

            Assert.IsNotNull(lan);
        }

        [TestMethod]
        public void LanGet()
        {
            Configure();
            var newLan = lanApi.FindById(datacenter.Id, lan.Id, depth: 5);
            Assert.AreEqual(lan.Id, newLan.Id);
        }

        [TestMethod]
        public void LanList()
        {
            Configure();
            var list = lanApi.FindAll(datacenter.Id, depth: 5);
            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void LanUpdate()
        {
            Configure();
            var updated = lanApi.PartialUpdate(datacenter.Id, lan.Id, new LanProperties { Public = !lan.Properties.Public });
            Assert.AreEqual(!lan.Properties.Public, updated.Properties.Public);
        }

        [TestMethod]
        public void LanDelete()
        {
            Configure();
            var resp = lanApi.Delete(datacenter.Id, lan.Id);
            resp = dcApi.Delete(datacenter.Id);
        }

        private void DoWait(string requestUrl)
        {
            if (string.IsNullOrEmpty(requestUrl))
                return;
            var requestApi = new RequestApi(configuration);

            var sub = requestUrl.Substring(requestUrl.IndexOf("requests/") + 9, 36);
            var request = new RequestStatus();
            int counter = 0;

            do
            {
                request = requestApi.GetStatus(sub);
                counter++;
                Thread.Sleep(1000);
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }

    }
}
