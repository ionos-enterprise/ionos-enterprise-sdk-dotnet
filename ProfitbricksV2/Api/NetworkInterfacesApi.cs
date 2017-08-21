using  Client;
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
    public interface INetworkInterfacesApi
    {

        Nic AttachNic(string datacenterId, string serverId, Nic nic);

        InlineResponse202 DetachNic(string datacenterId, string loadbalancerId, string nicId);

        /// <summary>
        /// List Nics
        /// </summary>
        /// <remarks>
        /// Retrieves a list of NICs.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nics</returns>
        Nics FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Nics
        /// </summary>
        /// <remarks>
        /// Retrieves a list of NICs.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nics</returns>
        ApiResponse<Nics> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Nics
        /// </summary>
        /// <remarks>
        /// Retrieves a list of NICs.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nics</returns>
        System.Threading.Tasks.Task<Nics> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Nics
        /// </summary>
        /// <remarks>
        /// Retrieves a list of NICs.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nics)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nics>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Nic
        /// </summary>
        /// <remarks>
        /// Adds a NIC to the target server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic Create(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Nic
        /// </summary>
        /// <remarks>
        /// Adds a NIC to the target server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> CreateWithHttpInfo(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Nic
        /// </summary>
        /// <remarks>
        /// Adds a NIC to the target server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> CreateAsync(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Nic
        /// </summary>
        /// <remarks>
        /// Adds a NIC to the target server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> CreateAsyncWithHttpInfo(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Nic
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic FindById(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Nic
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> FindByIdWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Nic
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> FindByIdAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Nic
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic Update(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> UpdateWithHttpInfo(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> UpdateAsync(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> UpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Nic
        /// </summary>
        /// <remarks>
        /// Deletes the specified NIC.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Nic
        /// </summary>
        /// <remarks>
        /// Deletes the specified NIC.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Nic
        /// </summary>
        /// <remarks>
        /// Deletes the specified NIC.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Nic
        /// </summary>
        /// <remarks>
        /// Deletes the specified NIC.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Nic</returns>
        Nic PartialUpdate(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Nic</returns>
        ApiResponse<Nic> PartialUpdateWithHttpInfo(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        System.Threading.Tasks.Task<Nic> PartialUpdateAsync(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Nic
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a Nic
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nic>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NetworkInterfacesApi : INetworkInterfacesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInterfacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NetworkInterfacesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInterfacesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NetworkInterfacesApi(Configuration configuration = null)
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
        /// List Nics Retrieves a list of NICs.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nics</returns>
        public Nics FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nics> response = FindAllWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Nics Retrieves a list of NICs.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nics</returns>
        public ApiResponse<Nics> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->FindAll");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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

            return new ApiResponse<Nics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nics)Configuration.ApiClient.Deserialize(response, typeof(Nics)));

        }

        /// <summary>
        /// List Nics Retrieves a list of NICs.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nics</returns>
        public async System.Threading.Tasks.Task<Nics> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nics> response = await FindAllAsyncWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Nics Retrieves a list of NICs.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nics>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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

            return new ApiResponse<Nics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nics)Configuration.ApiClient.Deserialize(response, typeof(Nics)));

        }

        public Nic AttachNic(string datacenterId, string serverId, Nic nic)
        {
            ApiResponse<Nic> response = AttachNicWithHttpInfo(datacenterId, serverId, nic);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        public ApiResponse<Nic> AttachNicWithHttpInfo(string datacenterId, string loadbalancerId, Nic nic, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedVolumesApi->AttachVolume");

            // verify the required parameter 'serverId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedVolumesApi->AttachVolume");

            // verify the required parameter 'volume' is set
            if (nic == null)
                throw new ApiException(400, "Missing required parameter 'volume' when calling AttachedVolumesApi->AttachVolume");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}/balancednics";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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
        /// Create a Nic Adds a NIC to the target server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nic">Nic to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic Create(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = CreateWithHttpInfo(datacenterId, serverId, nic, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a Nic Adds a NIC to the target server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nic">Nic to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> CreateWithHttpInfo(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->Create");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->Create");

            // verify the required parameter 'nic' is set
            if (nic == null)
                throw new ApiException(400, "Missing required parameter 'nic' when calling NetworkInterfacesApi->Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Create a Nic Adds a NIC to the target server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> CreateAsync(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await CreateAsyncWithHttpInfo(datacenterId, serverId, nic, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create a Nic Adds a NIC to the target server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nic">Nic to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> CreateAsyncWithHttpInfo(string datacenterId, string serverId, Nic nic, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Create");
            // verify the required parameter 'nic' is set
            if (nic == null) throw new ApiException(400, "Missing required parameter 'nic' when calling Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Retrieve a Nic Retrieves the attributes of a given NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic FindById(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = FindByIdWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Nic Retrieves the attributes of a given NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> FindByIdWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->FindById");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->FindById");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling NetworkInterfacesApi->FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
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
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Retrieve a Nic Retrieves the attributes of a given NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> FindByIdAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await FindByIdAsyncWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a Nic Retrieves the attributes of a given NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindById");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
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
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="nic">Modified Nic</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic Update(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = UpdateWithHttpInfo(datacenterId, serverId, nicId, nic, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="nic">Modified Nic</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> UpdateWithHttpInfo(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->Update");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->Update");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling NetworkInterfacesApi->Update");

            // verify the required parameter 'nic' is set
            if (nic == null)
                throw new ApiException(400, "Missing required parameter 'nic' when calling NetworkInterfacesApi->Update");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> UpdateAsync(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await UpdateAsyncWithHttpInfo(datacenterId, serverId, nicId, nic, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> UpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, Nic nic, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Update");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Update");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling Update");
            // verify the required parameter 'nic' is set
            if (nic == null) throw new ApiException(400, "Missing required parameter 'nic' when calling Update");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Delete a Nic Deletes the specified NIC.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Nic Deletes the specified NIC.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->Delete");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->Delete");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling NetworkInterfacesApi->Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
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
        /// Delete a Nic Deletes the specified NIC.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Nic Deletes the specified NIC.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Delete");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
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
        /// Partially modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="nic">Modified properties of Nic</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Nic</returns>
        public Nic PartialUpdate(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = PartialUpdateWithHttpInfo(datacenterId, serverId, nicId, nic, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="nic">Modified properties of Nic</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Nic</returns>
        public ApiResponse<Nic> PartialUpdateWithHttpInfo(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->PartialUpdate");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->PartialUpdate");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling NetworkInterfacesApi->PartialUpdate");

            // verify the required parameter 'nic' is set
            if (nic == null)
                throw new ApiException(400, "Missing required parameter 'nic' when calling NetworkInterfacesApi->PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        /// <summary>
        /// Partially modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Nic</returns>
        public async System.Threading.Tasks.Task<Nic> PartialUpdateAsync(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Nic> response = await PartialUpdateAsyncWithHttpInfo(datacenterId, serverId, nicId, nic, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Nic You can use update attributes of a Nic
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="nic">Modified properties of Nic</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Nic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Nic>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, NicProperties nic, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling PartialUpdate");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling PartialUpdate");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling PartialUpdate");
            // verify the required parameter 'nic' is set
            if (nic == null) throw new ApiException(400, "Missing required parameter 'nic' when calling PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter

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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PartialUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));

        }

        public InlineResponse202 DetachNic(string datacenterId, string loadbalancerId, string nicId)
        {
            ApiResponse<InlineResponse202> response = DetachNicWithHttpInfo(datacenterId, loadbalancerId, nicId);
            return response.Data;
        }

        private ApiResponse<InlineResponse202> DetachNicWithHttpInfo(string datacenterId, string loadbalancerId, string nicId)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling NetworkInterfacesApi->Delete");

            // verify the required parameter 'serverId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling NetworkInterfacesApi->Delete");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling NetworkInterfacesApi->Delete");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}/balancednics/{nicId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            
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
    }

}
