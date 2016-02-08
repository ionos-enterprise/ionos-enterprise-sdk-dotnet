using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using  Client;
using  Model;


namespace  Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVolumeApi
    {

        /// <summary>
        /// List Volumes
        /// </summary>
        /// <remarks>
        /// Retrieves a list of Volumes.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volumes</returns>
        Volumes FindAll(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Volumes
        /// </summary>
        /// <remarks>
        /// Retrieves a list of Volumes.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volumes</returns>
        ApiResponse<Volumes> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Volumes
        /// </summary>
        /// <remarks>
        /// Retrieves a list of Volumes.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volumes</returns>
        System.Threading.Tasks.Task<Volumes> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Volumes
        /// </summary>
        /// <remarks>
        /// Retrieves a list of Volumes.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volumes)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volumes>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Volume
        /// </summary>
        /// <remarks>
        /// Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume Create(string datacenterId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Volume
        /// </summary>
        /// <remarks>
        /// Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> CreateWithHttpInfo(string datacenterId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Volume
        /// </summary>
        /// <remarks>
        /// Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> CreateAsync(string datacenterId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Volume
        /// </summary>
        /// <remarks>
        /// Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> CreateAsyncWithHttpInfo(string datacenterId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Volume
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume FindById(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Volume
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> FindByIdWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Volume
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> FindByIdAsync(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Volume
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> FindByIdAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume Update(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> UpdateWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> UpdateAsync(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> UpdateAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Volume
        /// </summary>
        /// <remarks>
        /// Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Volume
        /// </summary>
        /// <remarks>
        /// Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Volume
        /// </summary>
        /// <remarks>
        /// Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Volume
        /// </summary>
        /// <remarks>
        /// Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume PartialUpdate(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> PartialUpdateWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> PartialUpdateAsync(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Volume
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Volume
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> PartialUpdateAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create Volume Snapshot
        /// </summary>
        /// <remarks>
        /// Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Error</returns>
        Error CreateSnapshot(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create Volume Snapshot
        /// </summary>
        /// <remarks>
        /// Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> CreateSnapshotWithHttpInfo(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create Volume Snapshot
        /// </summary>
        /// <remarks>
        /// Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> CreateSnapshotAsync(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create Volume Snapshot
        /// </summary>
        /// <remarks>
        /// Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> CreateSnapshotAsyncWithHttpInfo(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Restore Volume Snapshot
        /// </summary>
        /// <remarks>
        /// This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Error</returns>
        Error RestoreSnapshot(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Restore Volume Snapshot
        /// </summary>
        /// <remarks>
        /// This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> RestoreSnapshotWithHttpInfo(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Restore Volume Snapshot
        /// </summary>
        /// <remarks>
        /// This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> RestoreSnapshotAsync(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Restore Volume Snapshot
        /// </summary>
        /// <remarks>
        /// This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> RestoreSnapshotAsyncWithHttpInfo(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VolumeApi : IVolumeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VolumeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VolumeApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        /// List Volumes Retrieves a list of Volumes.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volumes</returns>
        public Volumes FindAll(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volumes> response = FindAllWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Volumes Retrieves a list of Volumes.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volumes</returns>
        public ApiResponse<Volumes> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/volumes";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.collection+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter





            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volumes>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volumes)Configuration.ApiClient.Deserialize(response, typeof(Volumes)));

        }

        /// <summary>
        /// List Volumes Retrieves a list of Volumes.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volumes</returns>
        public async System.Threading.Tasks.Task<Volumes> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volumes> response = await FindAllAsyncWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Volumes Retrieves a list of Volumes.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volumes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volumes>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/volumes";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.collection+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volumes>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volumes)Configuration.ApiClient.Deserialize(response, typeof(Volumes)));

        }

        /// <summary>
        /// Create a Volume Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volume">Volume to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume Create(string datacenterId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = CreateWithHttpInfo(datacenterId, volume, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Create a Volume Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volume">Volume to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> CreateWithHttpInfo(string datacenterId, Volume volume, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->Create");

            // verify the required parameter 'volume' is set
            if (volume == null)
                throw new ApiException(400, "Missing required parameter 'volume' when calling VolumeApi->Create");


            var path_ = "/datacenters/{datacenterId}/volumes";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "application/vnd.profitbricks.resource+json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (volume.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter
            }
            else
            {
                postBody = volume; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Create a Volume Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> CreateAsync(string datacenterId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await CreateAsyncWithHttpInfo(datacenterId, volume, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create a Volume Creates a volume within the datacenter. This will not attach the volume to a server. Please see the Servers section for details on how to attach storage volumes
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volume">Volume to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> CreateAsyncWithHttpInfo(string datacenterId, Volume volume, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'volume' is set
            if (volume == null) throw new ApiException(400, "Missing required parameter 'volume' when calling Create");


            var path_ = "/datacenters/{datacenterId}/volumes";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "application/vnd.profitbricks.resource+json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Retrieve a Volume Retrieves the attributes of a given Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume FindById(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = FindByIdWithHttpInfo(datacenterId, volumeId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Volume Retrieves the attributes of a given Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> FindByIdWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->FindById");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->FindById");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter





            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Retrieve a Volume Retrieves the attributes of a given Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> FindByIdAsync(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await FindByIdAsyncWithHttpInfo(datacenterId, volumeId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a Volume Retrieves the attributes of a given Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> FindByIdAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="volume">Modified Volume</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume Update(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = UpdateWithHttpInfo(datacenterId, volumeId, volume, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="volume">Modified Volume</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> UpdateWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->Update");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->Update");

            // verify the required parameter 'volume' is set
            if (volume == null)
                throw new ApiException(400, "Missing required parameter 'volume' when calling VolumeApi->Update");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "application/vnd.profitbricks.resource+json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (volume.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter
            }
            else
            {
                postBody = volume; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> UpdateAsync(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await UpdateAsyncWithHttpInfo(datacenterId, volumeId, volume, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> UpdateAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, Volume volume, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Update");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling Update");
            // verify the required parameter 'volume' is set
            if (volume == null) throw new ApiException(400, "Missing required parameter 'volume' when calling Update");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "application/vnd.profitbricks.resource+json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Delete a Volume Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, volumeId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Volume Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->Delete");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->Delete");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter





            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));

        }

        /// <summary>
        /// Delete a Volume Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, volumeId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Volume Deletes the specified volume. This will result in the volume being removed from your datacenter. Use this with caution.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "*/*"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));

        }

        /// <summary>
        /// Partially modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="volume">Modified properties of Volume</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume PartialUpdate(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = PartialUpdateWithHttpInfo(datacenterId, volumeId, volume, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="volume">Modified properties of Volume</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> PartialUpdateWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->PartialUpdate");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->PartialUpdate");

            // verify the required parameter 'volume' is set
            if (volume == null)
                throw new ApiException(400, "Missing required parameter 'volume' when calling VolumeApi->PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/vnd.profitbricks.partial-properties+json", "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (volume.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter
            }
            else
            {
                postBody = volume; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Partially modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> PartialUpdateAsync(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await PartialUpdateAsyncWithHttpInfo(datacenterId, volumeId, volume, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Volume You can use update attributes of a Volume
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="volume">Modified properties of Volume</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> PartialUpdateAsyncWithHttpInfo(string datacenterId, Dictionary<string, string> volumeId, VolumeProperties volume, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling PartialUpdate");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling PartialUpdate");
            // verify the required parameter 'volume' is set
            if (volume == null) throw new ApiException(400, "Missing required parameter 'volume' when calling PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/vnd.profitbricks.partial-properties+json", "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(volume); // http body (model) parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Create Volume Snapshot Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="name">The name of the snapshot</param> 
        /// <param name="description">The description of the snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Error</returns>
        public Error CreateSnapshot(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Error> response = CreateSnapshotWithHttpInfo(datacenterId, volumeId, name, description, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Create Volume Snapshot Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="name">The name of the snapshot</param> 
        /// <param name="description">The description of the snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> CreateSnapshotWithHttpInfo(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->CreateSnapshot");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->CreateSnapshot");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}/create-snapshot";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter


            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (description != null) formParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling CreateSnapshot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling CreateSnapshot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Error>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Error)Configuration.ApiClient.Deserialize(response, typeof(Error)));

        }

        /// <summary>
        /// Create Volume Snapshot Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> CreateSnapshotAsync(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Error> response = await CreateSnapshotAsyncWithHttpInfo(datacenterId, volumeId, name, description, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create Volume Snapshot Creates a snapshot of a volume within the datacenter. You can use a snapshot to create a new storage volume or to restore a storage volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">The name of the snapshot</param>
        /// <param name="description">The description of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> CreateSnapshotAsyncWithHttpInfo(string datacenterId, string volumeId, string name = null, string description = null, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling CreateSnapshot");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling CreateSnapshot");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}/create-snapshot";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter


            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (description != null) formParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter




            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling CreateSnapshot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling CreateSnapshot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Error>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Error)Configuration.ApiClient.Deserialize(response, typeof(Error)));

        }

        /// <summary>
        /// Restore Volume Snapshot This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="name">This is the ID of the snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Error</returns>
        public Error RestoreSnapshot(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Error> response = RestoreSnapshotWithHttpInfo(datacenterId, volumeId, name, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Restore Volume Snapshot This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="name">This is the ID of the snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> RestoreSnapshotWithHttpInfo(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling VolumeApi->RestoreSnapshot");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling VolumeApi->RestoreSnapshot");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}/restore-snapshot";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter


            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling RestoreSnapshot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling RestoreSnapshot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Error>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Error)Configuration.ApiClient.Deserialize(response, typeof(Error)));

        }

        /// <summary>
        /// Restore Volume Snapshot This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> RestoreSnapshotAsync(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Error> response = await RestoreSnapshotAsyncWithHttpInfo(datacenterId, volumeId, name, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Restore Volume Snapshot This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create subsequent volumes if you want or to restore an existing volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="volumeId"></param>
        /// <param name="name">This is the ID of the snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> RestoreSnapshotAsyncWithHttpInfo(string datacenterId, string volumeId, string name = null, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling RestoreSnapshot");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling RestoreSnapshot");


            var path_ = "/datacenters/{datacenterId}/volumes/{volumeId}/restore-snapshot";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.profitbricks.resource+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (volumeId != null) pathParams.Add("volumeId", Configuration.ApiClient.ParameterToString(volumeId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter


            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter




            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling RestoreSnapshot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling RestoreSnapshot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Error>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Error)Configuration.ApiClient.Deserialize(response, typeof(Error)));

        }

    }

}
