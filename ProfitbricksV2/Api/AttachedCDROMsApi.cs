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
    public interface IAttachedCDROMsApi
    {

        /// <summary>
        /// List attached CD-ROMs
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of CD-ROMs attached to the server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Cdroms</returns>
        Cdroms FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List attached CD-ROMs
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of CD-ROMs attached to the server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Cdroms</returns>
        ApiResponse<Cdroms> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List attached CD-ROMs
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of CD-ROMs attached to the server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Cdroms</returns>
        System.Threading.Tasks.Task<Cdroms> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List attached CD-ROMs
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of CD-ROMs attached to the server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Cdroms)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cdroms>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a CD-ROM
        /// </summary>
        /// <remarks>
        /// You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Image</returns>
        Image Attach(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a CD-ROM
        /// </summary>
        /// <remarks>
        /// You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Image</returns>
        ApiResponse<Image> AttachWithHttpInfo(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a CD-ROM
        /// </summary>
        /// <remarks>
        /// You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        System.Threading.Tasks.Task<Image> AttachAsync(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Attach a CD-ROM
        /// </summary>
        /// <remarks>
        /// You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        System.Threading.Tasks.Task<ApiResponse<Image>> AttachAsyncWithHttpInfo(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached CD-ROM
        /// </summary>
        /// <remarks>
        /// You can retrieve a specific CD-ROM attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Image</returns>
        Image FindById(string datacenterId, string serverId,string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached CD-ROM
        /// </summary>
        /// <remarks>
        /// You can retrieve a specific CD-ROM attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Image</returns>
        ApiResponse<Image> FindByIdWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached CD-ROM
        /// </summary>
        /// <remarks>
        /// You can retrieve a specific CD-ROM attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        System.Threading.Tasks.Task<Image> FindByIdAsync(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an attached CD-ROM
        /// </summary>
        /// <remarks>
        /// You can retrieve a specific CD-ROM attached to the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        System.Threading.Tasks.Task<ApiResponse<Image>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a CD-ROM
        /// </summary>
        /// <remarks>
        /// This will detach a CD-ROM from the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a CD-ROM
        /// </summary>
        /// <remarks>
        /// This will detach a CD-ROM from the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a CD-ROM
        /// </summary>
        /// <remarks>
        /// This will detach a CD-ROM from the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Detach a CD-ROM
        /// </summary>
        /// <remarks>
        /// This will detach a CD-ROM from the server
        /// </remarks>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachedCDROMsApi : IAttachedCDROMsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedCDROMsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachedCDROMsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedCDROMsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttachedCDROMsApi(Configuration configuration = null)
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
        /// List attached CD-ROMs You can retrieve a list of CD-ROMs attached to the server.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Cdroms</returns>
        public Cdroms FindAll(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Cdroms> response = FindAllWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List attached CD-ROMs You can retrieve a list of CD-ROMs attached to the server.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Cdroms</returns>
        public ApiResponse<Cdroms> FindAllWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedCDROMsApi->FindAll");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedCDROMsApi->FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms";

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

            return new ApiResponse<Cdroms>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cdroms)Configuration.ApiClient.Deserialize(response, typeof(Cdroms)));

        }

        /// <summary>
        /// List attached CD-ROMs You can retrieve a list of CD-ROMs attached to the server.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Cdroms</returns>
        public async System.Threading.Tasks.Task<Cdroms> FindAllAsync(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Cdroms> response = await FindAllAsyncWithHttpInfo(datacenterId, serverId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List attached CD-ROMs You can retrieve a list of CD-ROMs attached to the server.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Cdroms)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cdroms>> FindAllAsyncWithHttpInfo(string datacenterId, string serverId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindAll");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindAll");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms";

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

            return new ApiResponse<Cdroms>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cdroms)Configuration.ApiClient.Deserialize(response, typeof(Cdroms)));

        }

        /// <summary>
        /// Attach a CD-ROM You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdrom">CD-ROM to be attached</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Image</returns>
        public Image Attach(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = AttachWithHttpInfo(datacenterId, serverId, cdrom, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Attach a CD-ROM You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdrom">CD-ROM to be attached</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Image</returns>
        public ApiResponse<Image> AttachWithHttpInfo(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedCDROMsApi->Create");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedCDROMsApi->Create");

            // verify the required parameter 'cdrom' is set
            if (cdrom == null)
                throw new ApiException(400, "Missing required parameter 'cdrom' when calling AttachedCDROMsApi->Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms";

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



            if (cdrom.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(cdrom); // http body (model) parameter
            }
            else
            {
                postBody = cdrom; // byte array
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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Attach a CD-ROM You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        public async System.Threading.Tasks.Task<Image> AttachAsync(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = await AttachAsyncWithHttpInfo(datacenterId, serverId, cdrom, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;

        }

        /// <summary>
        /// Attach a CD-ROM You can attach a CD-ROM to an existing server. You can attach up to 2 CD-ROMs to one server.
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdrom">CD-ROM to be attached</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Image>> AttachAsyncWithHttpInfo(string datacenterId, string serverId, Image cdrom, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Create");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Create");
            // verify the required parameter 'cdrom' is set
            if (cdrom == null) throw new ApiException(400, "Missing required parameter 'cdrom' when calling Create");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms";

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



            postBody = Configuration.ApiClient.Serialize(cdrom); // http body (model) parameter



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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Retrieve an attached CD-ROM You can retrieve a specific CD-ROM attached to the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdromId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Image</returns>
        public Image FindById(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = FindByIdWithHttpInfo(datacenterId, serverId, cdromId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve an attached CD-ROM You can retrieve a specific CD-ROM attached to the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdromId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Image</returns>
        public ApiResponse<Image> FindByIdWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedCDROMsApi->FindById");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedCDROMsApi->FindById");

            // verify the required parameter 'cdromId' is set
            if (cdromId == null)
                throw new ApiException(400, "Missing required parameter 'cdromId' when calling AttachedCDROMsApi->FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms/{cdromId}";

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
            if (cdromId != null) pathParams.Add("cdromId", Configuration.ApiClient.ParameterToString(cdromId)); // path parameter

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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Retrieve an attached CD-ROM You can retrieve a specific CD-ROM attached to the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        public async System.Threading.Tasks.Task<Image> FindByIdAsync(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = await FindByIdAsyncWithHttpInfo(datacenterId, serverId, cdromId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve an attached CD-ROM You can retrieve a specific CD-ROM attached to the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Image>> FindByIdAsyncWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling FindById");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling FindById");
            // verify the required parameter 'cdromId' is set
            if (cdromId == null) throw new ApiException(400, "Missing required parameter 'cdromId' when calling FindById");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms/{cdromId}";

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
            if (cdromId != null) pathParams.Add("cdromId", Configuration.ApiClient.ParameterToString(cdromId)); // path parameter

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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Detach a CD-ROM This will detach a CD-ROM from the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdromId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(datacenterId, serverId, cdromId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Detach a CD-ROM This will detach a CD-ROM from the server
        /// </summary>
        /// <param name="datacenterId"></param> 
        /// <param name="serverId"></param> 
        /// <param name="cdromId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null)
                throw new ApiException(400, "Missing required parameter 'datacenterId' when calling AttachedCDROMsApi->Delete");

            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling AttachedCDROMsApi->Delete");

            // verify the required parameter 'cdromId' is set
            if (cdromId == null)
                throw new ApiException(400, "Missing required parameter 'cdromId' when calling AttachedCDROMsApi->Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms/{cdromId}";

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
            if (cdromId != null) pathParams.Add("cdromId", Configuration.ApiClient.ParameterToString(cdromId)); // path parameter

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
        /// Detach a CD-ROM This will detach a CD-ROM from the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(datacenterId, serverId, cdromId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Detach a CD-ROM This will detach a CD-ROM from the server
        /// </summary>
        /// <param name="datacenterId"></param>
        /// <param name="serverId"></param>
        /// <param name="cdromId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string datacenterId, string serverId, string cdromId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'datacenterId' is set
            if (datacenterId == null) throw new ApiException(400, "Missing required parameter 'datacenterId' when calling Delete");
            // verify the required parameter 'serverId' is set
            if (serverId == null) throw new ApiException(400, "Missing required parameter 'serverId' when calling Delete");
            // verify the required parameter 'cdromId' is set
            if (cdromId == null) throw new ApiException(400, "Missing required parameter 'cdromId' when calling Delete");


            var path_ = "/datacenters/{datacenterId}/servers/{serverId}/cdroms/{cdromId}";

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
            if (cdromId != null) pathParams.Add("cdromId", Configuration.ApiClient.ParameterToString(cdromId)); // path parameter

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
