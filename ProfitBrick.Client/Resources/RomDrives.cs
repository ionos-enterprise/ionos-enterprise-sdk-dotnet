using ProfitBricks.Client.ProfitBricksProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Drives service class.
    /// </summary>
    public class Drives
    {
        /// <summary>
        /// ProfitbricksApiServicePortTypeClient client.
        /// </summary>
        public ProfitbricksApiServicePortTypeClient Client { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Drives(ProfitbricksApiServicePortTypeClient client)
        {
            Client = client;
        }
        
        /// <summary>
        /// Adds a CD-ROM/DVD drive to an existing virtual server. Maximum CD-ROM/DVD Drives are currently 2.
        /// </summary>
        /// <param name="imageId">Identifier of the CD-ROM/DVD image</param>
        /// <param name="serverId">Identifier of the target virtual server</param>
        /// <param name="deviceNumber">Device number of the CD-ROM/DVD drive connected to the server. If no device number is set, a new device number will be assigned to the CD-ROM/DVD drive automatically</param>
        public void AddRomDrive(string imageId, string serverId, int deviceNumber)
        {
            var request = new romDriveRequest { imageId = imageId, serverId = serverId, deviceNumber = deviceNumber };
            Client.addRomDriveToServer(request);
        }

        /// <summary>
        /// Removes a CD-ROM/DVD drive from an existing virtual server.
        /// </summary>
        /// <param name="imageId">Identifier of the CD-ROM/DVD image</param>
        /// <param name="serverId">Identifier of the target virtual server</param>
        public void RemoveRomDrive(string imageId, string serverId)
        {
            Client.removeRomDriveFromServer(imageId, serverId);
        }
    }
}
