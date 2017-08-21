using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Client;
using Model;

namespace Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShareApi
    {
        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of shares
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Shares</returns>
        Shares FindAll(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of shares
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Shares</returns>
        ApiResponse<Shares> FindAllWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of shares
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Shares</returns>
        System.Threading.Tasks.Task<Shares> FindAllAsync(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of shares
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Shares)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shares>> FindAllAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>
        /// Adds a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Share</returns>
        Share Add(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>
        /// Adds a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> AddWithHttpInfo(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>
        /// Adds a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> AddAsync(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>
        /// Adds a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> AddAsyncWithHttpInfo(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>
        /// Returns information about a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Share</returns>
        Share FindById(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>
        /// Returns information about a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> FindByIdWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>
        /// Returns information about a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> FindByIdAsync(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>
        /// Returns information about a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> FindByIdAsyncWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Share</returns>
        Share Update(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> UpdateWithHttpInfo(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> UpdateAsync(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> UpdateAsyncWithHttpInfo(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>
        /// This will remove a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Remove(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>
        /// This will remove a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> RemoveWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>
        /// This will remove a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> RemoveAsync(string groupId, string shareId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>
        /// This will remove a share
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> RemoveAsyncWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShareApi : IShareApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShareApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShareApi(Configuration configuration = null)
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
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>You can retrieve a list of shares</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Shares</returns>
        public Shares FindAll(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Shares> response = FindAllWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>You can retrieve a list of shares</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Shares</returns>
        public ApiResponse<Shares> FindAllWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling FindAll");

            var path_ = "/um/groups/{groupId}/shares";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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

            return new ApiResponse<Shares>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shares)Configuration.ApiClient.Deserialize(response, typeof(Shares)));

        }

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>You can retrieve a list of shares</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Shares</returns>
        public async System.Threading.Tasks.Task<Shares> FindAllAsync(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Shares> response = await FindAllAsyncWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Shares
        /// </summary>
        /// <remarks>You can retrieve a list of shares</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Shares)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Shares>> FindAllAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling FindAllAsync");

            var path_ = "/um/groups/{groupId}/shares";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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

            return new ApiResponse<Shares>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shares)Configuration.ApiClient.Deserialize(response, typeof(Shares)));

        }

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>You can add a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Share</returns>
        public Share Add(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = AddWithHttpInfo(groupId, resourceId, share, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>You can add a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse<Share> AddWithHttpInfo(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->Add");
            // verify the required parameter 'resourceId' is set
            if (string.IsNullOrEmpty(resourceId))
                throw new ApiException(400, "Missing required parameter 'resourceId' when calling ShareApi->Add");
            // verify the required parameter 'share' is set
            if (share == null)
                throw new ApiException(400, "Missing required parameter 'share' when calling ShareApi->Add");

            var path_ = "/um/groups/{groupId}/shares/{resourceId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("resourceId", Configuration.ApiClient.ParameterToString(resourceId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            if (share.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(share); // http body (model) parameter
            }
            else
            {
                postBody = share; // byte array
            }

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
                throw new ApiException(statusCode, "Error calling Add: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Add: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>You can add a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> AddAsync(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = await AddAsyncWithHttpInfo(groupId, resourceId, share, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Add a Share
        /// </summary>
        /// <remarks>You can add a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="share">Share to be added</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> AddAsyncWithHttpInfo(string groupId, string resourceId, Share share, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->AddAsync");
            // verify the required parameter 'resourceId' is set
            if (string.IsNullOrEmpty(resourceId))
                throw new ApiException(400, "Missing required parameter 'resourceId' when calling ShareApi->AddAsync");
            // verify the required parameter 'share' is set
            if (share == null)
                throw new ApiException(400, "Missing required parameter 'share' when calling ShareApi->AddAsync");

            var path_ = "/um/groups/{groupId}/shares/{resourceId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("resourceId", Configuration.ApiClient.ParameterToString(resourceId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            postBody = Configuration.ApiClient.Serialize(share); // http body (model) parameter

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
                throw new ApiException(statusCode, "Error calling Add: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Add: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Retrieve a Share Returns information about a share
        /// </summary>
        /// <remarks>You can add a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Share</returns>
        public Share FindById(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = FindByIdWithHttpInfo(groupId, shareId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>You can retreive a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse<Share> FindByIdWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->FindById");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ShareApi->FindById");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>You can retreive a share</remarks>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> FindByIdAsync(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = await FindByIdAsyncWithHttpInfo(groupId, shareId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Share
        /// </summary>
        /// <remarks>You can retreive a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> FindByIdAsyncWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling FindByIdAsync");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling FindByIdAsync");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>You can update attributes of a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param> 
        /// <param name="share">Modified Share</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Share</returns>
        public Share Update(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = UpdateWithHttpInfo(groupId, shareId, share, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>You can update attributes of a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param> 
        /// <param name="share">Modified Share</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse<Share> UpdateWithHttpInfo(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->Update");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ShareApi->Update");
            // verify the required parameter 'share' is set
            if (share == null)
                throw new ApiException(400, "Missing required parameter 'share' when calling ShareApi->Update");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            if (share.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(share); // http body (model) parameter
            }
            else
            {
                postBody = share; // byte array
            }

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

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>You can update attributes of a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> UpdateAsync(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Share> response = await UpdateAsyncWithHttpInfo(groupId, shareId, share, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Share
        /// </summary>
        /// <remarks>You can update attributes of a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId">The unique ID of the share</param>
        /// <param name="share">Modified Share</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> UpdateAsyncWithHttpInfo(string groupId, string shareId, Share share, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->UpdateAsync");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ShareApi->UpdateAsync");
            // verify the required parameter 'share' is set
            if (share == null)
                throw new ApiException(400, "Missing required parameter 'share' when calling ShareApi-> UpdateAsync");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            postBody = Configuration.ApiClient.Serialize(share); // http body (model) parameter

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

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share)Configuration.ApiClient.Deserialize(response, typeof(Share)));
        }

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>This will remove a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Remove(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = RemoveWithHttpInfo(groupId, shareId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>This will remove a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> RemoveWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->Remove");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ShareApi->Remove");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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
                throw new ApiException(statusCode, "Error calling Remove: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Remove: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>This will remove a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> RemoveAsync(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await RemoveAsyncWithHttpInfo(groupId, shareId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Remove a Share
        /// </summary>
        /// <remarks>This will remove a share</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="shareId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> RemoveAsyncWithHttpInfo(string groupId, string shareId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling ShareApi->RemoveAsync");
            // verify the required parameter 'shareId' is set
            if (string.IsNullOrEmpty(shareId))
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ShareApi->RemoveAsync");

            var path_ = "/um/groups/{groupId}/shares/{shareId}";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
            pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

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
                throw new ApiException(statusCode, "Error calling Remove: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Remove: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }
    }
}
