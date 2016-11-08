using Client;
using  Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;


namespace  Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILanApi
    {

        /// <summary>
        /// List Lans
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Lans</returns>
        Lans FindAll(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lans
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Lans</returns>
        ApiResponse<Lans> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lans
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lans</returns>
        System.Threading.Tasks.Task<Lans> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lans
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lans)</returns>
        System.Threading.Tasks.Task<ApiResponse<Lans>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a LAN within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Lan</returns>
        Lan Create(string datacenterId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a LAN within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Lan</returns>
        ApiResponse<Lan> CreateWithHttpInfo(string datacenterId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a LAN within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        System.Threading.Tasks.Task<Lan> CreateAsync(string datacenterId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a LAN within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Lan>> CreateAsyncWithHttpInfo(string datacenterId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Lan
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given LAN
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Lan</returns>
        Lan FindById(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Lan
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given LAN
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Lan</returns>
        ApiResponse<Lan> FindByIdWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Lan
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given LAN
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        System.Threading.Tasks.Task<Lan> FindByIdAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Lan
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given LAN
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Lan>> FindByIdAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Lan</returns>
        Lan Update(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Lan</returns>
        ApiResponse<Lan> UpdateWithHttpInfo(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        System.Threading.Tasks.Task<Lan> UpdateAsync(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Lan>> UpdateAsyncWithHttpInfo(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Lan.
        /// </summary>
        /// <remarks>
        /// Removes the specific Lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Lan.
        /// </summary>
        /// <remarks>
        /// Removes the specific Lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Lan.
        /// </summary>
        /// <remarks>
        /// Removes the specific Lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Lan.
        /// </summary>
        /// <remarks>
        /// Removes the specific Lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Lan</returns>
        Lan PartialUpdate(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Lan</returns>
        ApiResponse<Lan> PartialUpdateWithHttpInfo(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        System.Threading.Tasks.Task<Lan> PartialUpdateAsync(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Lan
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Lan>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lan Members
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of nics attached to a lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>LanNics</returns>
        LanNics ListNics(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lan Members
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of nics attached to a lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of LanNics</returns>
        ApiResponse<LanNics> ListNicsWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lan Members
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of nics attached to a lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of LanNics</returns>
        System.Threading.Tasks.Task<LanNics> ListNicsAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Lan Members
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of nics attached to a lan
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (LanNics)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanNics>> ListNicsAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a nic
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing nic to a lan.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic AttachNic(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a nic
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing nic to a lan.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> AttachNicWithHttpInfo(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a nic
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing nic to a lan.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> AttachNicAsync(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a nic
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing nic to a lan.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> AttachNicAsyncWithHttpInfo(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a nic attached to lan
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached nic.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic GetMember(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a nic attached to lan
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached nic.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> GetMemberWithHttpInfo(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a nic attached to lan
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached nic.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> GetMemberAsync(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a nic attached to lan
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached nic.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> GetMemberAsyncWithHttpInfo(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LanApi : ILanApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanApi(Configuration configuration = null)
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
        /// List Lans Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Lans</returns>
        public Lans FindAll(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lans> response = FindAllWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Lans Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Lans</returns>
        public ApiResponse<Lans> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/lans";

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
                "application/json"
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

            return new ApiResponse<Lans>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lans)Configuration.ApiClient.Deserialize(response, typeof(Lans)));

        }

        /// <summary>
        /// List Lans Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lans</returns>
        public async System.Threading.Tasks.Task<Lans> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lans> response = await FindAllAsyncWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Lans Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lans)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Lans>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/lans";

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
                "application/json"
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

            return new ApiResponse<Lans>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lans)Configuration.ApiClient.Deserialize(response, typeof(Lans)));

        }

        /// <summary>
        /// Create a Lan Creates a LAN within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lan">Lan to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Lan</returns>
        public Lan Create(string datacenterId, Lan lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = CreateWithHttpInfo(datacenterId, lan, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a Lan Creates a LAN within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lan">Lan to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Lan</returns>
        public ApiResponse<Lan> CreateWithHttpInfo(string datacenterId, Lan lan, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->Create");

            // verify the required parameter 'lan' is set
            if (lan == null)
                throw new ApiException(400, "Missing required parameter 'lan' when calling LanApi->Create");


            var path_ = "/datacenters/{datacenterId}/lans";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
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



            if (lan.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter
            }
            else
            {
                postBody = lan; // byte array
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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Create a Lan Creates a LAN within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        public async System.Threading.Tasks.Task<Lan> CreateAsync(string datacenterId, Lan lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = await CreateAsyncWithHttpInfo(datacenterId, lan, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create a Lan Creates a LAN within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lan">Lan to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Lan>> CreateAsyncWithHttpInfo(string datacenterId, Lan lan, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'lan' is set
            if (lan == null) throw new ApiException(400, "Missing required parameter 'lan' when calling Create");


            var path_ = "/datacenters/{datacenterId}/lans";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
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



            postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter



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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Retrieve a Lan Retrieves the attributes of a given LAN
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Lan</returns>
        public Lan FindById(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = FindByIdWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Lan Retrieves the attributes of a given LAN
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Lan</returns>
        public ApiResponse<Lan> FindByIdWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->FindById");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->FindById");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Retrieve a Lan Retrieves the attributes of a given LAN
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        public async System.Threading.Tasks.Task<Lan> FindByIdAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = await FindByIdAsyncWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a Lan Retrieves the attributes of a given LAN
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Lan>> FindByIdAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="lan">Modified Lan</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Lan</returns>
        public Lan Update(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = UpdateWithHttpInfo(datacenterId, lanId, lan, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="lan">Modified Lan</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Lan</returns>
        public ApiResponse<Lan> UpdateWithHttpInfo(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->Update");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->Update");

            // verify the required parameter 'lan' is set
            if (lan == null)
                throw new ApiException(400, "Missing required parameter 'lan' when calling LanApi->Update");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (lan.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter
            }
            else
            {
                postBody = lan; // byte array
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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        public async System.Threading.Tasks.Task<Lan> UpdateAsync(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = await UpdateAsyncWithHttpInfo(datacenterId, lanId, lan, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Lan>> UpdateAsyncWithHttpInfo(string datacenterId, string lanId, Lan lan, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Update");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling Update");
            // verify the required parameter 'lan' is set
            if (lan == null) throw new ApiException(400, "Missing required parameter 'lan' when calling Update");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter



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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Delete a Lan. Removes the specific Lan
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Lan. Removes the specific Lan
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->Delete");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->Delete");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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
        /// Delete a Lan. Removes the specific Lan
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Lan. Removes the specific Lan
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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
        /// Partially modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="lan">Modified Lan</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Lan</returns>
        public Lan PartialUpdate(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = PartialUpdateWithHttpInfo(datacenterId, lanId, lan, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="lan">Modified Lan</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Lan</returns>
        public ApiResponse<Lan> PartialUpdateWithHttpInfo(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->PartialUpdate");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->PartialUpdate");

            // verify the required parameter 'lan' is set
            if (lan == null)
                throw new ApiException(400, "Missing required parameter 'lan' when calling LanApi->PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                 "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (lan.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter
            }
            else
            {
                postBody = lan; // byte array
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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// Partially modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Lan</returns>
        public async System.Threading.Tasks.Task<Lan> PartialUpdateAsync(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Lan> response = await PartialUpdateAsyncWithHttpInfo(datacenterId, lanId, lan, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Lan You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="lan">Modified Lan</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Lan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Lan>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string lanId, LanProperties lan, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling PartialUpdate");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling PartialUpdate");
            // verify the required parameter 'lan' is set
            if (lan == null) throw new ApiException(400, "Missing required parameter 'lan' when calling PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                 "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(lan); // http body (model) parameter



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

            return new ApiResponse<Lan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Lan)Configuration.ApiClient.Deserialize(response, typeof(Lan)));

        }

        /// <summary>
        /// List Lan Members You can retrieve a list of nics attached to a lan
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>LanNics</returns>
        public LanNics ListNics(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<LanNics> response = ListNicsWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Lan Members You can retrieve a list of nics attached to a lan
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of LanNics</returns>
        public ApiResponse<LanNics> ListNicsWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->ListNics");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->ListNics");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling ListNics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling ListNics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LanNics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanNics)Configuration.ApiClient.Deserialize(response, typeof(LanNics)));

        }

        /// <summary>
        /// List Lan Members You can retrieve a list of nics attached to a lan
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of LanNics</returns>
        public async System.Threading.Tasks.Task<LanNics> ListNicsAsync(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<LanNics> response = await ListNicsAsyncWithHttpInfo(datacenterId, lanId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Lan Members You can retrieve a list of nics attached to a lan
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (LanNics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanNics>> ListNicsAsyncWithHttpInfo(string datacenterId, string lanId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling ListNics");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling ListNics");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling ListNics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling ListNics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LanNics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanNics)Configuration.ApiClient.Deserialize(response, typeof(LanNics)));

        }

        /// <summary>
        /// Attach a nic This will attach a pre-existing nic to a lan.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="nic">Nic to be attached</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic AttachNic(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = AttachNicWithHttpInfo(datacenterId, lanId, nic, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Attach a nic This will attach a pre-existing nic to a lan.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="nic">Nic to be attached</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> AttachNicWithHttpInfo(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->AttachNic");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->AttachNic");

            // verify the required parameter 'nic' is set
            if (nic == null)
                throw new ApiException(400, "Missing required parameter 'nic' when calling LanApi->AttachNic");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (nic.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(nic); // http body (model) parameter
            }
            else
            {
                postBody = nic; // byte array
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
                throw new ApiException(statusCode, "Error calling AttachNic: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AttachNic: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Attach a nic This will attach a pre-existing nic to a lan.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> AttachNicAsync(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await AttachNicAsyncWithHttpInfo(datacenterId, lanId, nic, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Attach a nic This will attach a pre-existing nic to a lan.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nic">Nic to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> AttachNicAsyncWithHttpInfo(string datacenterId, string lanId, Nic nic, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachNic");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling AttachNic");
            // verify the required parameter 'nic' is set
            if (nic == null) throw new ApiException(400, "Missing required parameter 'nic' when calling AttachNic");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(nic); // http body (model) parameter



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
                throw new ApiException(statusCode, "Error calling AttachNic: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AttachNic: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Retrieve a nic attached to lan This will retrieve the properties of an attached nic.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic GetMember(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = GetMemberWithHttpInfo(datacenterId, lanId, nicId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a nic attached to lan This will retrieve the properties of an attached nic.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="lanId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> GetMemberWithHttpInfo(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LanApi->GetMember");

            // verify the required parameter 'lanId' is set
            if (lanId == null)
                throw new ApiException(400, "Missing required parameter 'lanId' when calling LanApi->GetMember");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling LanApi->GetMember");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics/{nicId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling GetMember: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling GetMember: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Retrieve a nic attached to lan This will retrieve the properties of an attached nic.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> GetMemberAsync(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await GetMemberAsyncWithHttpInfo(datacenterId, lanId, nicId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a nic attached to lan This will retrieve the properties of an attached nic.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="lanId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> GetMemberAsyncWithHttpInfo(string datacenterId, string lanId, string nicId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling GetMember");
            // verify the required parameter 'lanId' is set
            if (lanId == null) throw new ApiException(400, "Missing required parameter 'lanId' when calling GetMember");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling GetMember");


            var path_ = "/datacenters/{datacenterId}/lans/{lanId}/nics/{nicId}";

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
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (datacenterId != null) pathParams.Add("datacenterId", Configuration.ApiClient.ParameterToString(datacenterId)); // path parameter
            if (lanId != null) pathParams.Add("lanId", Configuration.ApiClient.ParameterToString(lanId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling GetMember: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling GetMember: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

    }

}
