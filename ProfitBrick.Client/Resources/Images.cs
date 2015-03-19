using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Images service class.
    /// </summary>
    public class Images : SoapService<Image>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Images(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Not supported
        /// </summary>
        /// <returns></returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createStorage(request.Cast<createStorageRequest>());
            return new CreateVolumeResponse { Id = response.storageId, DataCenterId = response.dataCenterId, DataCenterVersion = response.dataCenterVersion, RequestId = response.requestId };
        }

        /// <summary>
        /// Sets the OS Type of an individual HDD and/or CD-ROM/DVD image that has been uploaded on the ProfitBricks FTP server.  
        /// The default OS Type of an uploaded image is UNKOWN. Due to Microsoft’s terms and conditions, the user has to set the OS Type of an uploaded Windows image to WINDOWS and therewith accepts the terms and conditions as well as the pricing. Any server that is booted from the image will inherit the OS Type of the image automatically.
        /// </summary>
        /// <param name="imageId">Identifier of the target HDD or CD-ROM/DVD image</param>
        /// <param name="osType">OS Type of the target HDD or CD-ROM/DVD image (WINDOWS, LINUX, OTHER, UNKNOWN)</param>
        public void SetImageOsType(string imageId, OsType osType)
        {
            Client.setImageOsType(new imageOsTypeRequest { imageId = imageId, osType = (osType)osType });
        }

        /// <summary>
        /// Fetches list of all Images.
        /// </summary>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<Image> Get()
        {
            var images = Client.getAllImages();

            var toReturn = new List<Image>();

            foreach (var image in images)
            {
                toReturn.Add(Converters.ConvertImage(image));
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="id">Image identifier</param>
        /// <returns>Instance of POCO.Image</returns>
        public override Image Show(string id)
        {
            return Converters.ConvertImage(Client.getImage(id));
        }

        /// <summary>
        /// Updates information about a HDD or CD-ROM/DVD (ISO) image.
        /// </summary>
        /// <param name="obj">Image to be updated</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateImage(obj.Cast<updateImageRequest>());
        }

        /// <summary>
        /// Deletes an image. Please be aware that deleted images and related data in this image cannot be recovered anymore.
        /// </summary>
        /// <param name="id">Identifier of the image that shall get deleted.</param>
        public override void Delete(string id)
        {
            Client.deleteImage(id);
        }

        /// <summary>
        /// This will connect an existing storage volume to the specified server.
        /// </summary>
        public void Connect(ProfitBricksBase request)
        {
            Client.connectStorageToServer(request.Cast<connectStorageRequest>());
        }

        /// <summary>
        /// This will disconnect a volume from the specified server. This does not destroy the volume.
        /// </summary>
        public void Disconnect(string storageId, string serverId)
        {
            Client.disconnectStorageFromServer(storageId, serverId);
        }
    }
}
