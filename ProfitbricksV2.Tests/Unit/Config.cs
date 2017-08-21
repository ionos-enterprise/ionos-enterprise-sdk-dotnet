using Api;
using Client;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ProfitBricksSDK.Tests
{
    public class Config
    {
        public const string DefaultName = ".NET SDK Test";
        public const string DefaultLocation = "us/las";
        public const string ImageName = "Ubuntu-16";
        public const string NotFoundError = "Resource does not exist";
        public const string MissingAttributeError = "Attribute '{0}' is required";

        public static readonly string[] Locations = new string[] { "us/las", "us/ewr", "de/fra", "de/fkb" };
        public static readonly string[] LicenseTypes = new string[] { "LINUX", "WINDOWS", "WINDOWS2016", "OTHER", "UNKNOWN" };
        public static readonly string[] ImageTypes = new string[] { "CDROM", "HDD" };

        public static readonly Regex MacRegex = new Regex("^([0-9a-f]{2}[:]){5}([0-9a-f]{2})$");

        public static Configuration Configuration
        {
            get
            {
                return new Configuration
                {
                    Username = Environment.GetEnvironmentVariable("PROFITBRICKS_USERNAME"),
                    Password = Environment.GetEnvironmentVariable("PROFITBRICKS_PASSWORD"),
                    Timeout = 300000
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
                Thread.Sleep(2000);
                if (counter == 300)
                    break;
                else if (request.Metadata.Status == "FAILED")
                    throw new Exception(request.Metadata.Message);
            } while (request.Metadata.Status != "DONE");
        }
    }
}