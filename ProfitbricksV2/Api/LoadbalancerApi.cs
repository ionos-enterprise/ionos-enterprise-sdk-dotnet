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
    public interface ILoadBalancerApi
    {

        /// <summary>
        /// List Load Balancers
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Loadbalancers</returns>
        Loadbalancers FindAll(string datacenterId, bool? parameter = null, int? depth = null);

        BalancedNics FindAll(string datacenterId, string loadbalancerId, int? depth = null);

        Nic FindById(string datacenterId, string loadbalancerId, string nicId, int? depth = null);

        /// <summary>
        /// List Load Balancers
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Loadbalancers</returns>
        ApiResponse<Loadbalancers> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Load Balancers
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancers</returns>
        System.Threading.Tasks.Task<Loadbalancers> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Load Balancers
        /// </summary>
        /// <remarks>
        /// Retrieve a list of LANs within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancers)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loadbalancers>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a Loadbalancer within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Loadbalancer</returns>
        Loadbalancer Create(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a Loadbalancer within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Loadbalancer</returns>
        ApiResponse<Loadbalancer> CreateWithHttpInfo(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a Loadbalancer within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        System.Threading.Tasks.Task<Loadbalancer> CreateAsync(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Lan
        /// </summary>
        /// <remarks>
        /// Creates a Loadbalancer within the datacenter
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> CreateAsyncWithHttpInfo(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a loadbalancer
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Loadbalancer</returns>
        Loadbalancer FindById(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a loadbalancer
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Loadbalancer</returns>
        ApiResponse<Loadbalancer> FindByIdWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a loadbalancer
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        System.Threading.Tasks.Task<Loadbalancer> FindByIdAsync(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a loadbalancer
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> FindByIdAsyncWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Loadbalancer</returns>
        Loadbalancer Update(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Loadbalancer</returns>
        ApiResponse<Loadbalancer> UpdateWithHttpInfo(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        System.Threading.Tasks.Task<Loadbalancer> UpdateAsync(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> UpdateAsyncWithHttpInfo(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Loadbalancer.
        /// </summary>
        /// <remarks>
        /// Removes the specific Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Loadbalancer.
        /// </summary>
        /// <remarks>
        /// Removes the specific Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Loadbalancer.
        /// </summary>
        /// <remarks>
        /// Removes the specific Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Loadbalancer.
        /// </summary>
        /// <remarks>
        /// Removes the specific Loadbalancer
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Loadbalancer</returns>
        Loadbalancer PartialUpdate(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Loadbalancer</returns>
        ApiResponse<Loadbalancer> PartialUpdateWithHttpInfo(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        System.Threading.Tasks.Task<Loadbalancer> PartialUpdateAsync(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Loadbalancer
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoadBalancerApi : ILoadBalancerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoadBalancerApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoadBalancerApi(Configuration configuration = null)
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
        /// List Load Balancers Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Loadbalancers</returns>
        public Loadbalancers FindAll(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancers> response = FindAllWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;
        }

        public BalancedNics FindAll(string datacenterId, string loadbalancerId, int? depth = null)
        {
            ApiResponse<BalancedNics> response = FindBalancedAllWithHttpInfo(datacenterId, loadbalancerId,  depth);
            return response.Data;

        }

        public Nic FindById(string datacenterId, string loadbalancerId, string nicId,int? depth = null)
        {
            ApiResponse<Nic> response = FindBalancedByIdWithHttpInfo(datacenterId, loadbalancerId,nicId, depth);
            return response.Data;

        }

        public ApiResponse<BalancedNics> FindBalancedAllWithHttpInfo(string datacenterId, string loadbalancerId, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->FindAll");

            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->FindBalancedAll");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}/balancednics";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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

            return new ApiResponse<BalancedNics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BalancedNics)Configuration.ApiClient.Deserialize(response, typeof(BalancedNics)));
        }

        public ApiResponse<Nic> FindBalancedByIdWithHttpInfo(string datacenterId, string loadbalancerId,string nicId, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->FindById");

            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling LoadBalancerApi->FindById");

            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->FindById");

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
                "application/vnd.profitbricks.resource+json"
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

            return new ApiResponse<Nic>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Nic)Configuration.ApiClient.Deserialize(response, typeof(Nic)));
        }

        /// <summary>
        /// List Load Balancers Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Loadbalancers</returns>
        public ApiResponse<Loadbalancers> FindAllWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/loadbalancers";

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

            return new ApiResponse<Loadbalancers>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancers)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancers)));

        }

        /// <summary>
        /// List Load Balancers Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancers</returns>
        public async System.Threading.Tasks.Task<Loadbalancers> FindAllAsync(string datacenterId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancers> response = await FindAllAsyncWithHttpInfo(datacenterId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Load Balancers Retrieve a list of LANs within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Loadbalancers>> FindAllAsyncWithHttpInfo(string datacenterId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/loadbalancers";

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

            return new ApiResponse<Loadbalancers>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancers)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancers)));

        }

        /// <summary>
        /// Create a Lan Creates a Loadbalancer within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancer">Loadbalancer to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Loadbalancer</returns>
        public Loadbalancer Create(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = CreateWithHttpInfo(datacenterId, loadbalancer, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a Lan Creates a Loadbalancer within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancer">Loadbalancer to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Loadbalancer</returns>
        public ApiResponse<Loadbalancer> CreateWithHttpInfo(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->Create");

            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling LoadBalancerApi->Create");


            var path_ = "/datacenters/{datacenterId}/loadbalancers";

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



            if (loadbalancer.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter
            }
            else
            {
                postBody = loadbalancer; // byte array
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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Create a Lan Creates a Loadbalancer within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        public async System.Threading.Tasks.Task<Loadbalancer> CreateAsync(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = await CreateAsyncWithHttpInfo(datacenterId, loadbalancer, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create a Lan Creates a Loadbalancer within the datacenter
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancer">Loadbalancer to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> CreateAsyncWithHttpInfo(string datacenterId, Loadbalancer loadbalancer, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null) throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling Create");


            var path_ = "/datacenters/{datacenterId}/loadbalancers";

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



            postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter



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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Retrieve a loadbalancer Retrieves the attributes of a given Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Loadbalancer</returns>
        public Loadbalancer FindById(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = FindByIdWithHttpInfo(datacenterId, loadbalancerId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a loadbalancer Retrieves the attributes of a given Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Loadbalancer</returns>
        public ApiResponse<Loadbalancer> FindByIdWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->FindById");

            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->FindById");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Retrieve a loadbalancer Retrieves the attributes of a given Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        public async System.Threading.Tasks.Task<Loadbalancer> FindByIdAsync(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = await FindByIdAsyncWithHttpInfo(datacenterId, loadbalancerId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a loadbalancer Retrieves the attributes of a given Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> FindByIdAsyncWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null) throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="loadbalancer">Modified Loadbalancer</param> 
        /// <param name="body"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Loadbalancer</returns>
        public Loadbalancer Update(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = UpdateWithHttpInfo(datacenterId, loadbalancerId, loadbalancer, body, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="loadbalancer">Modified Loadbalancer</param> 
        /// <param name="body"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Loadbalancer</returns>
        public ApiResponse<Loadbalancer> UpdateWithHttpInfo(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->Update");

            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->Update");

            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling LoadBalancerApi->Update");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (loadbalancer.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter
            }
            else
            {
                postBody = loadbalancer; // byte array
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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        public async System.Threading.Tasks.Task<Loadbalancer> UpdateAsync(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = await UpdateAsyncWithHttpInfo(datacenterId, loadbalancerId, loadbalancer, body, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> UpdateAsyncWithHttpInfo(string datacenterId, string loadbalancerId, Loadbalancer loadbalancer, Body1 body = null, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Update");
            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null) throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling Update");
            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null) throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling Update");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter



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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Delete a Loadbalancer. Removes the specific Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, loadbalancerId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Loadbalancer. Removes the specific Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->Delete");

            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->Delete");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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
        /// Delete a Loadbalancer. Removes the specific Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, loadbalancerId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Loadbalancer. Removes the specific Loadbalancer
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string loadbalancerId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null) throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

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
        /// Partially modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="loadbalancer">Modified Loadbalancer</param> 
        /// <param name="body"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Loadbalancer</returns>
        public Loadbalancer PartialUpdate(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = PartialUpdateWithHttpInfo(datacenterId, loadbalancerId, loadbalancer, body, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="loadbalancerId"></param> 
        /// <param name="loadbalancer">Modified Loadbalancer</param> 
        /// <param name="body"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Loadbalancer</returns>
        public ApiResponse<Loadbalancer> PartialUpdateWithHttpInfo(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling LoadBalancerApi->PartialUpdate");

            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling LoadBalancerApi->PartialUpdate");

            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null)
                throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling LoadBalancerApi->PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (loadbalancer.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter
            }
            else
            {
                postBody = loadbalancer; // byte array
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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

        /// <summary>
        /// Partially modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Loadbalancer</returns>
        public async System.Threading.Tasks.Task<Loadbalancer> PartialUpdateAsync(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Loadbalancer> response = await PartialUpdateAsyncWithHttpInfo(datacenterId, loadbalancerId, loadbalancer, body, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Loadbalancer You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="loadbalancerId"></param>
        /// <param name="loadbalancer">Modified Loadbalancer</param>
        /// <param name="body"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Loadbalancer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Loadbalancer>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string loadbalancerId, LoadbalancerProperties loadbalancer, Body2 body = null, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling PartialUpdate");
            // verify the required parameter 'loadbalancerId' is set
            if (loadbalancerId == null) throw new ApiException(400, "Missing required parameter 'loadbalancerId' when calling PartialUpdate");
            // verify the required parameter 'loadbalancer' is set
            if (loadbalancer == null) throw new ApiException(400, "Missing required parameter 'loadbalancer' when calling PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/loadbalancers/{loadbalancerId}";

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
            if (loadbalancerId != null) pathParams.Add("loadbalancerId", Configuration.ApiClient.ParameterToString(loadbalancerId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(loadbalancer); // http body (model) parameter



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

            return new ApiResponse<Loadbalancer>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Loadbalancer)Configuration.ApiClient.Deserialize(response, typeof(Loadbalancer)));

        }

    }

}
