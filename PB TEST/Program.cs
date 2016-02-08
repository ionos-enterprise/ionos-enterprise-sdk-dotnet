using  Api;
using  Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration
            {
                Username = "vendors@stackpointcloud.com",
                Password = "d:;,%28*4$EZW98/",
                
            };

            DataCenterApi dcapi = new DataCenterApi(config);

            var dcs = dcapi.FindAll(depth: 5);
        }
    }
}