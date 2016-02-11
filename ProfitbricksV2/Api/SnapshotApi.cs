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
    public interface ISnapshotApi
    {

        /// <summary>
        /// List Snapshots
        /// </summary>
        /// <remarks>
        /// Retrieve a list of snapshots within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Snapshots</returns>
        Snapshots FindAll(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Snapshots
        /// </summary>
        /// <remarks>
        /// Retrieve a list of snapshots within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Snapshots</returns>
        ApiResponse<Snapshots> FindAllWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Snapshots
        /// </summary>
        /// <remarks>
        /// Retrieve a list of snapshots within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshots</returns>
        System.Threading.Tasks.Task<Snapshots> FindAllAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Snapshots
        /// </summary>
        /// <remarks>
        /// Retrieve a list of snapshots within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshots)</returns>
        System.Threading.Tasks.Task<ApiResponse<Snapshots>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Snapshot
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Snapshot</returns>
        Snapshot FindById(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Snapshot
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Snapshot</returns>
        ApiResponse<Snapshot> FindByIdWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Snapshot
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        System.Threading.Tasks.Task<Snapshot> FindByIdAsync(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Snapshot
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<Snapshot>> FindByIdAsyncWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Snapshot</returns>
        Snapshot Update(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Snapshot</returns>
        ApiResponse<Snapshot> UpdateWithHttpInfo(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        System.Threading.Tasks.Task<Snapshot> UpdateAsync(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<Snapshot>> UpdateAsyncWithHttpInfo(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Snapshot
        /// </summary>
        /// <remarks>
        /// Deletes the specified Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Snapshot
        /// </summary>
        /// <remarks>
        /// Deletes the specified Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Snapshot
        /// </summary>
        /// <remarks>
        /// Deletes the specified Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Snapshot
        /// </summary>
        /// <remarks>
        /// Deletes the specified Snapshot.
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Snapshot</returns>
        Snapshot PartialUpdate(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Snapshot</returns>
        ApiResponse<Snapshot> PartialUpdateWithHttpInfo(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        System.Threading.Tasks.Task<Snapshot> PartialUpdateAsync(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify a Snapshot
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<Snapshot>> PartialUpdateAsyncWithHttpInfo(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SnapshotApi : ISnapshotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SnapshotApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SnapshotApi(Configuration configuration = null)
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
        /// List Snapshots Retrieve a list of snapshots within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Snapshots</returns>
        public Snapshots FindAll(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshots> response = FindAllWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Snapshots Retrieve a list of snapshots within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Snapshots</returns>
        public ApiResponse<Snapshots> FindAllWithHttpInfo(bool? parameter = null, int? depth = null)
        {


            var path_ = "/snapshots";

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

            return new ApiResponse<Snapshots>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshots)Configuration.ApiClient.Deserialize(response, typeof(Snapshots)));

        }

        /// <summary>
        /// List Snapshots Retrieve a list of snapshots within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshots</returns>
        public async System.Threading.Tasks.Task<Snapshots> FindAllAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshots> response = await FindAllAsyncWithHttpInfo(parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Snapshots Retrieve a list of snapshots within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshots)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Snapshots>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {


            var path_ = "/snapshots";

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

            return new ApiResponse<Snapshots>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshots)Configuration.ApiClient.Deserialize(response, typeof(Snapshots)));

        }

        /// <summary>
        /// Retrieve a Snapshot Retrieves the attributes of a given Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Snapshot</returns>
        public Snapshot FindById(string snapshotId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = FindByIdWithHttpInfo(snapshotId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Snapshot Retrieves the attributes of a given Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Snapshot</returns>
        public ApiResponse<Snapshot> FindByIdWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null)
                throw new ApiException(400, "Missing required parameter 'snapshotId' when calling SnapshotApi->FindById");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

        /// <summary>
        /// Retrieve a Snapshot Retrieves the attributes of a given Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        public async System.Threading.Tasks.Task<Snapshot> FindByIdAsync(string snapshotId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = await FindByIdAsyncWithHttpInfo(snapshotId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve a Snapshot Retrieves the attributes of a given Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Snapshot>> FindByIdAsyncWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null) throw new ApiException(400, "Missing required parameter 'snapshotId' when calling FindById");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

        /// <summary>
        /// Modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="snapshot">Modified Snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Snapshot</returns>
        public Snapshot Update(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = UpdateWithHttpInfo(snapshotId, snapshot, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="snapshot">Modified Snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Snapshot</returns>
        public ApiResponse<Snapshot> UpdateWithHttpInfo(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null)
                throw new ApiException(400, "Missing required parameter 'snapshotId' when calling SnapshotApi->Update");

            // verify the required parameter 'snapshot' is set
            if (snapshot == null)
                throw new ApiException(400, "Missing required parameter 'snapshot' when calling SnapshotApi->Update");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (snapshot.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(snapshot); // http body (model) parameter
            }
            else
            {
                postBody = snapshot; // byte array
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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

        /// <summary>
        /// Modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        public async System.Threading.Tasks.Task<Snapshot> UpdateAsync(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = await UpdateAsyncWithHttpInfo(snapshotId, snapshot, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Snapshot>> UpdateAsyncWithHttpInfo(string snapshotId, Snapshot snapshot, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null) throw new ApiException(400, "Missing required parameter 'snapshotId' when calling Update");
            // verify the required parameter 'snapshot' is set
            if (snapshot == null) throw new ApiException(400, "Missing required parameter 'snapshot' when calling Update");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(snapshot); // http body (model) parameter



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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

        /// <summary>
        /// Delete a Snapshot Deletes the specified Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string snapshotId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(snapshotId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Snapshot Deletes the specified Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null)
                throw new ApiException(400, "Missing required parameter 'snapshotId' when calling SnapshotApi->Delete");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

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
        /// Delete a Snapshot Deletes the specified Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string snapshotId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(snapshotId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete a Snapshot Deletes the specified Snapshot.
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string snapshotId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null) throw new ApiException(400, "Missing required parameter 'snapshotId' when calling Delete");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

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
        /// Partially modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="snapshot">Modified Snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Snapshot</returns>
        public Snapshot PartialUpdate(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = PartialUpdateWithHttpInfo(snapshotId, snapshot, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param> 
        /// <param name="snapshot">Modified Snapshot</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Snapshot</returns>
        public ApiResponse<Snapshot> PartialUpdateWithHttpInfo(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null)
                throw new ApiException(400, "Missing required parameter 'snapshotId' when calling SnapshotApi->PartialUpdate");

            // verify the required parameter 'snapshot' is set
            if (snapshot == null)
                throw new ApiException(400, "Missing required parameter 'snapshot' when calling SnapshotApi->PartialUpdate");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (snapshot.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(snapshot); // http body (model) parameter
            }
            else
            {
                postBody = snapshot; // byte array
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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

        /// <summary>
        /// Partially modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Snapshot</returns>
        public async System.Threading.Tasks.Task<Snapshot> PartialUpdateAsync(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Snapshot> response = await PartialUpdateAsyncWithHttpInfo(snapshotId, snapshot, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify a Snapshot You can use update attributes of a resource
        /// </summary>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot">Modified Snapshot</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Snapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Snapshot>> PartialUpdateAsyncWithHttpInfo(string snapshotId, SnapshotProperties snapshot, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'snapshotId' is set
            if (snapshotId == null) throw new ApiException(400, "Missing required parameter 'snapshotId' when calling PartialUpdate");
            // verify the required parameter 'snapshot' is set
            if (snapshot == null) throw new ApiException(400, "Missing required parameter 'snapshot' when calling PartialUpdate");


            var path_ = "/snapshots/{snapshotId}";

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
            if (snapshotId != null) pathParams.Add("snapshotId", Configuration.ApiClient.ParameterToString(snapshotId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(snapshot); // http body (model) parameter



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

            return new ApiResponse<Snapshot>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Snapshot)Configuration.ApiClient.Deserialize(response, typeof(Snapshot)));

        }

    }

}
