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
    public interface IAttachedVolumesApi
    {

        /// <summary>
        /// List Attached Volumes
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of volumes attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>AttachedVolumes</returns>
        AttachedVolumes FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Attached Volumes
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of volumes attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of AttachedVolumes</returns>
        ApiResponse<AttachedVolumes> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Attached Volumes
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of volumes attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of AttachedVolumes</returns>
        System.Threading.Tasks.Task<AttachedVolumes> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Attached Volumes
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of volumes attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (AttachedVolumes)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttachedVolumes>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a volume
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume AttachVolume(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a volume
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> AttachVolumeWithHttpInfo(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a volume
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> AttachVolumeAsync(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a volume
        /// </summary>
        /// <remarks>
        /// This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> AttachVolumeAsyncWithHttpInfo(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached volume
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Volume</returns>
        Volume FindById(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached volume
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Volume</returns>
        ApiResponse<Volume> FindByIdWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached volume
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        System.Threading.Tasks.Task<Volume> FindByIdAsync(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached volume
        /// </summary>
        /// <remarks>
        /// This will retrieve the properties of an attached volume.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        System.Threading.Tasks.Task<ApiResponse<Volume>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a volume
        /// </summary>
        /// <remarks>
        /// This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a volume
        /// </summary>
        /// <remarks>
        /// This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a volume
        /// </summary>
        /// <remarks>
        /// This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a volume
        /// </summary>
        /// <remarks>
        /// This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachedVolumesApi : IAttachedVolumesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedVolumesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachedVolumesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedVolumesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttachedVolumesApi(Configuration configuration = null)
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
        /// List Attached Volumes You can retrieve a list of volumes attached to the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>AttachedVolumes</returns>
        public AttachedVolumes FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<AttachedVolumes> response = FindAllWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Attached Volumes You can retrieve a list of volumes attached to the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of AttachedVolumes</returns>
        public ApiResponse<AttachedVolumes> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedVolumesApi->FindAll");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedVolumesApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes";

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

            return new ApiResponse<AttachedVolumes>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachedVolumes)Configuration.ApiClient.Deserialize(response, typeof(AttachedVolumes)));

        }

        /// <summary>
        /// List Attached Volumes You can retrieve a list of volumes attached to the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of AttachedVolumes</returns>
        public async System.Threading.Tasks.Task<AttachedVolumes> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<AttachedVolumes> response = await FindAllAsyncWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Attached Volumes You can retrieve a list of volumes attached to the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (AttachedVolumes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttachedVolumes>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes";

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

            return new ApiResponse<AttachedVolumes>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachedVolumes)Configuration.ApiClient.Deserialize(response, typeof(AttachedVolumes)));

        }

        /// <summary>
        /// Attach a volume This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volume">Volume to be attached (created and attached)</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume AttachVolume(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = AttachVolumeWithHttpInfo(datacenterId, serverId, volume, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Attach a volume This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volume">Volume to be attached (created and attached)</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> AttachVolumeWithHttpInfo(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedVolumesApi->AttachVolume");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedVolumesApi->AttachVolume");

            // verify the required parameter 'volume' is set
            if (volume == null)
                throw new ApiException(400, "Missing required parameter 'volume' when calling AttachedVolumesApi->AttachVolume");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling AttachVolume: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AttachVolume: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Attach a volume This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> AttachVolumeAsync(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await AttachVolumeAsyncWithHttpInfo(datacenterId, serverId, volume, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Attach a volume This will attach a pre-existing storage volume to the server. It is also possible to create and attach a volume in one step just by providing a new volume description as payload.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volume">Volume to be attached (created and attached)</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> AttachVolumeAsyncWithHttpInfo(string datacenterId, string serverId, Volume volume, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachVolume");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachVolume");
            // verify the required parameter 'volume' is set
            if (volume == null) throw new ApiException(400, "Missing required parameter 'volume' when calling AttachVolume");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes";

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
            if (serverId != null) pathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling AttachVolume: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AttachVolume: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Volume>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Volume)Configuration.ApiClient.Deserialize(response, typeof(Volume)));

        }

        /// <summary>
        /// Retrieve an attached volume This will retrieve the properties of an attached volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Volume</returns>
        public Volume FindById(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = FindByIdWithHttpInfo(datacenterId, serverId, volumeId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve an attached volume This will retrieve the properties of an attached volume.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Volume</returns>
        public ApiResponse<Volume> FindByIdWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedVolumesApi->FindById");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedVolumesApi->FindById");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling AttachedVolumesApi->FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes/{volumeId}";

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
        /// Retrieve an attached volume This will retrieve the properties of an attached volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Volume</returns>
        public async System.Threading.Tasks.Task<Volume> FindByIdAsync(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Volume> response = await FindByIdAsyncWithHttpInfo(datacenterId, serverId, volumeId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve an attached volume This will retrieve the properties of an attached volume.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Volume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Volume>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindById");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes/{volumeId}";

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
        /// Detach a volume This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, serverId, volumeId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Detach a volume This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="volumeId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedVolumesApi->Delete");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedVolumesApi->Delete");

            // verify the required parameter 'volumeId' is set
            if (volumeId == null)
                throw new ApiException(400, "Missing required parameter 'volumeId' when calling AttachedVolumesApi->Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes/{volumeId}";

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
        /// Detach a volume This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, serverId, volumeId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Detach a volume This will detach the volume from the server. This will not delete the volume from your datacenter. You will need to make a separate request to perform a deletion
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="volumeId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, Dictionary<string, string> volumeId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Delete");
            // verify the required parameter 'volumeId' is set
            if (volumeId == null) throw new ApiException(400, "Missing required parameter 'volumeId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/volumes/{volumeId}";

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

    }

}
