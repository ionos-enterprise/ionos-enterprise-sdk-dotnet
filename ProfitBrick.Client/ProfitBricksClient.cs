using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.Client.Resources;
using System;
using System.Configuration;

namespace ProfitBricks.Client
{
    /// <summary>
    /// ProfitBricksClient class is a wrapper of all the PB resouces 
    /// </summary>
    public partial class ProfitBricksSoapClient
    {
        /// <summary>
        /// Private singleton instance.
        /// </summary>
        private static volatile ProfitBricksSoapClient instance;

        /// <summary>
        /// Padlock
        /// </summary>
        private static object syncRoot = new Object();

        /// <summary>
        /// Profit Brick API Service instance.
        /// </summary>
        ProfitbricksApiServicePortTypeClient Service { get; set; }

        /// <summary>
        /// Private constructor.
        /// </summary>
        private ProfitBricksSoapClient()
        {
            Service = new ProfitbricksApiServicePortTypeClient();
            Service.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["UserName"];
            Service.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["Password"];
        }

        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static ProfitBricksSoapClient Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ProfitBricksSoapClient();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Servers resource
        /// </summary>
        public Servers Servers
        {
            get
            {
                return new Servers(Service);
            }
        }

        /// <summary>
        /// DataCenters resource.
        /// </summary>
        public DataCenters DataCenters { get { return new DataCenters(Service); } }

        /// <summary>
        /// Volumes resource
        /// </summary>
        public Volumes Volumes { get { return new Volumes(Service); } }

        /// <summary>
        /// Snapshots resource
        /// </summary>
        public Snapshots Snapshots { get { return new Snapshots(Service); } }

        public LoadBalancers LoadBalancers { get { return new LoadBalancers(Service); } }

        public Firewalls Firewalls { get { return new Firewalls(Service); } }

        public Nics Nics { get { return new Nics(Service); } }

        public Images Images { get { return new Images(Service); } }

        public Drives Drives { get { return new Drives(Service); } }

        public PublicIpBlocks PublicIpBlocks { get { return new PublicIpBlocks(Service); } } 

        public UserNotifications UserNotifications { get { return new UserNotifications(Service); } }
    }
}
