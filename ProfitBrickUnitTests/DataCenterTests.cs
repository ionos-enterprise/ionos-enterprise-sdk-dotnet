using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class DataCenterTests
    {
        #region DataCenter
        DataCenters DataCenters = ProfitBricksSoapClient.Instance().DataCenters;

        static string dcId = string.Empty;


        [TestMethod]
        public void CreateDataCenter()
        {
            var request = new CreateDataCenterRequest
            {
                DataCenterName = "test",
                Location = Location.uslas
            };

            var response = DataCenters.Create(request);
         
            dcId = response.Id;
        }

        [TestMethod]
        public void GetAllDataCenters()
        {
            var dcs = DataCenters.Get();

            Assert.IsNotNull(dcs);
            Assert.IsTrue(dcs.Count > 0);
        }

        [TestMethod]
        public void GetOneDataCenter()
        {
            Assert.IsTrue(!string.IsNullOrEmpty(dcId));

            var dc = DataCenters.Show(dcId);

            Assert.IsNotNull(dc);
            Assert.IsTrue((dc as DataCenter).DataCenterId == dcId);
        }

        [TestMethod]
        public void ClearDataCenter()
        {
            DataCenters.ClearDataCenter(dcId);
        }

        [TestMethod]
        public void UpdateDataCenter()
        {
            var request = new UpdateDataCenterRequest
            {
                DataCenterId = dcId,
                DataCenterName = "new Name"
            };

            DataCenters.Update(request);

            var dc = DataCenters.Show(dcId);

            Assert.AreEqual(dc.DataCenterName, request.DataCenterName);
        }

        [TestMethod]
        public void DeleteDataCenter()
        {
            DataCenters.Delete(dcId);
        }

        #endregion
    }
}
