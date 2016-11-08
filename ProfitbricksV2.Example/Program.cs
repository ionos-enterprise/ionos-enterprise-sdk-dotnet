using Api;
using Client;
using Model;
using System;

namespace ProfitbricksV2.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration
            {
                Username = Environment.GetEnvironmentVariable("PROFITBRICKS_USERNAME"),
                Password = Environment.GetEnvironmentVariable("PROFITBRICKS_PASSWORD"),
            };
            var dcApi = new DataCenterApi(configuration);
            var serverApi = new ServerApi(configuration);
            var volumeApi = new VolumeApi(configuration);
            var attachedVolumesApi = new AttachedVolumesApi(configuration);
            var nicApi = new NetworkInterfacesApi(configuration);

            var dc = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = "test",
                    Location = "us/las"
                }
            };

            dc = dcApi.Create(dc);
             
            // Fetches list of all Data Centers
            var dcs = dcApi.FindAll(depth: 5);

         

        }
    }
}
