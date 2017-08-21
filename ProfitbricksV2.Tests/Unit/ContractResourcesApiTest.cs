using Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class ContractResourcesApiTests
    {
        ContractResourcesApi crApi = new ContractResourcesApi(Config.Configuration);

        [TestMethod]
        public void ContractResourcesList()
        {
            var contracts = crApi.List();
            Assert.AreEqual(contracts.Type, "contract");
            Assert.IsNotNull(contracts.Properties.ContractNumber);
        }
    }
}