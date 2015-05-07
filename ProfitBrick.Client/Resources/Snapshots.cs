using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Snapshots service class
    /// </summary>
    public class Snapshots : SoapService<Snapshot>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Snapshots(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateSnapshotRequest
        /// </summary>
        /// <returns>POCO.CreateSnapshotRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createSnapshot(request.Cast<createSnapshotRequest>());

            return new CreateSnapshotResponse { Id = response.snapshotId, RequestId = response.requestId };
        }

        /// <summary>
        /// Fetches list of all Snapshots.
        /// </summary>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<Snapshot> Get()
        {
            var snapshots = Client.getAllSnapshots();
            var toReturn = new List<Snapshot>();

            if (snapshots != null)
            {
                foreach (var snapshot in snapshots)
                {
                    toReturn.Add(Converters.ConvertSnapshot(snapshot));
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="id">Snapshot identifier</param>
        /// <returns>Instance of POCO.Snapshot</returns>
        public override Snapshot Show(string id)
        {
            return Converters.ConvertSnapshot(Client.getSnapshot(id));
        }

        /// <summary>
        /// Updates an instance of Snapshot.
        /// </summary>
        /// <param name="obj">Instance of POCO.Snapshot</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateSnapshot(obj.Cast<updateSnapshotRequest>());
        }

        /// <summary>
        /// Deletes a snapshot. Please be aware that deleted snapshots and related data in this snapshot cannot be recovered anymore.
        /// </summary>
        /// <param name="id">Identifier of the snapshot that shall get deleted</param>
        public override void Delete(string id)
        {
            Client.deleteSnapshot(id);
        }

        /// <summary>
        /// Using the rollback option you may redeploy the snapshotted state on a storage.
        /// Attention: The current state of the storage will be lost unless you create another snapshot before rolling back.
        /// </summary>
        /// <param name="request">Snapshot to be rolled back.</param>
        public void RollbackSnapshot(RollbackSnapshotRequest request)
        {
            Client.rollbackSnapshot(request.Cast<rollbackSnapshotRequest>());
        }
    }
}
