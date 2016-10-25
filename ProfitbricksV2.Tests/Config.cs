using Api;
using Client;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProfitbricksV2.Tests
{
    public class Config
    {

        public static Configuration Configuration
        {
            get
            {
                return new Configuration
                {
                    Username = Environment.GetEnvironmentVariable("PROFITBRICKS_USERNAME"),
                    Password = Environment.GetEnvironmentVariable("PROFITBRICKS_PASSWORD"),

                };
            }
        }


        public static void DoWait(string requestUrl)
        {
            if (string.IsNullOrEmpty(requestUrl))
                return;
            var requestApi = new RequestApi(Config.Configuration);

            var sub = requestUrl.Substring(requestUrl.IndexOf("requests/") + 9, 36);
            var request = new RequestStatus();
            int counter = 0;

            do
            {
                request = requestApi.GetStatus(sub);
                counter++;
                Thread.Sleep(1000);
                if (counter == 240)
                    break;
                else if (request.Metadata.Status == "FAILED")
                    throw new Exception(request.Metadata.Message);
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }
    }
}