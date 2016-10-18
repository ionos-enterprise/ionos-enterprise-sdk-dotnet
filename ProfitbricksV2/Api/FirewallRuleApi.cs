using Client;
using Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;


namespace  Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFirewallRuleApi
    {

        /// <summary>
        /// List Firewall Rules
        /// </summary>
        /// <remarks>
        /// Retrieves a list of firewall rules associated with a particular NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>FirewallRules</returns>
        FirewallRules FindAll(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Firewall Rules
        /// </summary>
        /// <remarks>
        /// Retrieves a list of firewall rules associated with a particular NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of FirewallRules</returns>
        ApiResponse<FirewallRules> FindAllWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Firewall Rules
        /// </summary>
        /// <remarks>
        /// Retrieves a list of firewall rules associated with a particular NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRules</returns>
        System.Threading.Tasks.Task<FirewallRules> FindAllAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Firewall Rules
        /// </summary>
        /// <remarks>
        /// Retrieves a list of firewall rules associated with a particular NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRules)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRules>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Firewall Rule
        /// </summary>
        /// <remarks>
        /// This will add a Firewall Rule to the NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>FirewallRule</returns>
        FirewallRule Create(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Firewall Rule
        /// </summary>
        /// <remarks>
        /// This will add a Firewall Rule to the NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of FirewallRule</returns>
        ApiResponse<FirewallRule> CreateWithHttpInfo(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Firewall Rule
        /// </summary>
        /// <remarks>
        /// This will add a Firewall Rule to the NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        System.Threading.Tasks.Task<FirewallRule> CreateAsync(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Firewall Rule
        /// </summary>
        /// <remarks>
        /// This will add a Firewall Rule to the NIC
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRule>> CreateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Firewall Rule.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>FirewallRule</returns>
        FirewallRule FindById(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Firewall Rule.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of FirewallRule</returns>
        ApiResponse<FirewallRule> FindByIdWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Firewall Rule.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        System.Threading.Tasks.Task<FirewallRule> FindByIdAsync(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Firewall Rule.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRule>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>FirewallRule</returns>
        FirewallRule Update(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of FirewallRule</returns>
        ApiResponse<FirewallRule> UpdateWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        System.Threading.Tasks.Task<FirewallRule> UpdateAsync(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRule>> UpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Removes the specific Firewall Rule
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Removes the specific Firewall Rule
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Removes the specific Firewall Rule
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Firewall Rule
        /// </summary>
        /// <remarks>
        /// Removes the specific Firewall Rule
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>FirewallRule</returns>
        FirewallRule PartialUpdate(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of FirewallRule</returns>
        ApiResponse<FirewallRule> PartialUpdateWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        System.Threading.Tasks.Task<FirewallRule> PartialUpdateAsync(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Firewall Rule
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRule>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FirewallRuleApi : IFirewallRuleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRuleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FirewallRuleApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRuleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FirewallRuleApi(Configuration configuration = null)
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
        /// List Firewall Rules Retrieves a list of firewall rules associated with a particular NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>FirewallRules</returns>
        public FirewallRules FindAll(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRules> response = FindAllWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Firewall Rules Retrieves a list of firewall rules associated with a particular NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of FirewallRules</returns>
        public ApiResponse<FirewallRules> FindAllWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->FindAll");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->FindAll");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules";

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
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FirewallRules>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRules)Configuration.ApiClient.Deserialize(response, typeof(FirewallRules)));

        }

        /// <summary>
        /// List Firewall Rules Retrieves a list of firewall rules associated with a particular NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRules</returns>
        public async System.Threading.Tasks.Task<FirewallRules> FindAllAsync(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRules> response = await FindAllAsyncWithHttpInfo(datacenterId, serverId, nicId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Firewall Rules Retrieves a list of firewall rules associated with a particular NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRules)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRules>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindAll");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules";

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
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FirewallRules>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRules)Configuration.ApiClient.Deserialize(response, typeof(FirewallRules)));

        }

        /// <summary>
        /// Create a Firewall Rule This will add a Firewall Rule to the NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallrule">Firewall Rule to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>FirewallRule</returns>
        public FirewallRule Create(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = CreateWithHttpInfo(datacenterId, serverId, nicId, firewallrule, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a Firewall Rule This will add a Firewall Rule to the NIC
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallrule">Firewall Rule to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of FirewallRule</returns>
        public ApiResponse<FirewallRule> CreateWithHttpInfo(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->Create");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->Create");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->Create");

            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null)
                throw new ApiException(400, "Missing required parameter 'firewallrule' when calling FirewallRuleApi->Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules";

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
                "application/vnd.profitbricks.resource+json"
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



            if (firewallrule.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter
            }
            else
            {
                postBody = firewallrule; // byte array
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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Create a Firewall Rule This will add a Firewall Rule to the NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        public async System.Threading.Tasks.Task<FirewallRule> CreateAsync(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = await CreateAsyncWithHttpInfo(datacenterId, serverId, nicId, firewallrule, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Create a Firewall Rule This will add a Firewall Rule to the NIC
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallrule">Firewall Rule to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRule>> CreateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Create");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling Create");
            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null) throw new ApiException(400, "Missing required parameter 'firewallrule' when calling Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules";

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
                "application/vnd.profitbricks.resource+json"
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



            postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter



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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Retrieve a Firewall Rule Retrieves the attributes of a given Firewall Rule.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>FirewallRule</returns>
        public FirewallRule FindById(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = FindByIdWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Firewall Rule Retrieves the attributes of a given Firewall Rule.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of FirewallRule</returns>
        public ApiResponse<FirewallRule> FindByIdWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->FindById");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->FindById");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->FindById");

            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null)
                throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling FirewallRuleApi->FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Retrieve a Firewall Rule Retrieves the attributes of a given Firewall Rule.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        public async System.Threading.Tasks.Task<FirewallRule> FindByIdAsync(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = await FindByIdAsyncWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a Firewall Rule Retrieves the attributes of a given Firewall Rule.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRule>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindById");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling FindById");
            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null) throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="firewallrule">Modified Firewall Rule</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>FirewallRule</returns>
        public FirewallRule Update(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = UpdateWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, firewallrule, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="firewallrule">Modified Firewall Rule</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of FirewallRule</returns>
        public ApiResponse<FirewallRule> UpdateWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->Update");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->Update");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->Update");

            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null)
                throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling FirewallRuleApi->Update");

            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null)
                throw new ApiException(400, "Missing required parameter 'firewallrule' when calling FirewallRuleApi->Update");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
                "application/vnd.profitbricks.resource+json"
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
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (firewallrule.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter
            }
            else
            {
                postBody = firewallrule; // byte array
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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        public async System.Threading.Tasks.Task<FirewallRule> UpdateAsync(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = await UpdateAsyncWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, firewallrule, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRule>> UpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallRule firewallrule, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Update");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Update");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling Update");
            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null) throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling Update");
            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null) throw new ApiException(400, "Missing required parameter 'firewallrule' when calling Update");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
                "application/vnd.profitbricks.resource+json"
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
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter



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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Delete a Firewall Rule Removes the specific Firewall Rule
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Firewall Rule Removes the specific Firewall Rule
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->Delete");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->Delete");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->Delete");

            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null)
                throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling FirewallRuleApi->Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

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
        /// Delete a Firewall Rule Removes the specific Firewall Rule
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Firewall Rule Removes the specific Firewall Rule
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Delete");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling Delete");
            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null) throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

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
        /// Partially modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="firewallrule">Modified Firewall Rule</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>FirewallRule</returns>
        public FirewallRule PartialUpdate(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = PartialUpdateWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, firewallrule, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="nicId"></param> 
        /// <param name="firewallruleId"></param> 
        /// <param name="firewallrule">Modified Firewall Rule</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of FirewallRule</returns>
        public ApiResponse<FirewallRule> PartialUpdateWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FirewallRuleApi->PartialUpdate");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallRuleApi->PartialUpdate");

            // verify the required parameter 'nicId' is set
            if (nicId == null)
                throw new ApiException(400, "Missing required parameter 'nicId' when calling FirewallRuleApi->PartialUpdate");

            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null)
                throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling FirewallRuleApi->PartialUpdate");

            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null)
                throw new ApiException(400, "Missing required parameter 'firewallrule' when calling FirewallRuleApi->PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (firewallrule.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter
            }
            else
            {
                postBody = firewallrule; // byte array
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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

        /// <summary>
        /// Partially modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of FirewallRule</returns>
        public async System.Threading.Tasks.Task<FirewallRule> PartialUpdateAsync(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null)
        {
            ApiResponse<FirewallRule> response = await PartialUpdateAsyncWithHttpInfo(datacenterId, serverId, nicId, firewallruleId, firewallrule, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Firewall Rule You can use update attributes of a resource
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="nicId"></param>
        /// <param name="firewallruleId"></param>
        /// <param name="firewallrule">Modified Firewall Rule</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (FirewallRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRule>> PartialUpdateAsyncWithHttpInfo(string datacenterId, string serverId, string nicId, string firewallruleId, FirewallruleProperties firewallrule, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling PartialUpdate");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling PartialUpdate");
            // verify the required parameter 'nicId' is set
            if (nicId == null) throw new ApiException(400, "Missing required parameter 'nicId' when calling PartialUpdate");
            // verify the required parameter 'firewallruleId' is set
            if (firewallruleId == null) throw new ApiException(400, "Missing required parameter 'firewallruleId' when calling PartialUpdate");
            // verify the required parameter 'firewallrule' is set
            if (firewallrule == null) throw new ApiException(400, "Missing required parameter 'firewallrule' when calling PartialUpdate");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/nics/{nicId}/firewallrules/{firewallruleId}";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (nicId != null) pathParams.Add("nicId", Configuration.ApiClient.ParameterToString(nicId)); // path parameter
            if (firewallruleId != null) pathParams.Add("firewallruleId", Configuration.ApiClient.ParameterToString(firewallruleId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(firewallrule); // http body (model) parameter



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

            return new ApiResponse<FirewallRule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRule)Configuration.ApiClient.Deserialize(response, typeof(FirewallRule)));

        }

    }

}
