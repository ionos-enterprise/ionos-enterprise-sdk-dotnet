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
    public interface IResourceApi
    {
        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ManagedResources</returns>
        ManagedResources FindAll(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of ManagedResources</returns>
        ApiResponse<ManagedResources> FindAllWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResources</returns>
        System.Threading.Tasks.Task<ManagedResources> FindAllAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResources)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagedResources>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ManagedResources</returns>
        ManagedResources FindAllByType(ResourceType type, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of ManagedResources</returns>
        ApiResponse<ManagedResources> FindAllByTypeWithHttpInfo(ResourceType type, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResources</returns>
        System.Threading.Tasks.Task<ManagedResources> FindAllByTypeAsync(ResourceType type, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResources)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagedResources>> FindAllByTypeAsyncWithHttpInfo(ResourceType type, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ManagedResource</returns>
        ManagedResource FindSpecificByType(ResourceType type, string resourceId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of ManagedResource</returns>
        ApiResponse<ManagedResource> FindSpecificByTypeWithHttpInfo(ResourceType type, string resourceId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResource</returns>
        System.Threading.Tasks.Task<ManagedResource> FindSpecificByTypeAsync(ResourceType type, string resourceId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagedResource>> FindSpecificByTypeAsyncWithHttpInfo(ResourceType type, string resourceId, bool? parameter = null, int? depth = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ResourceApi : IResourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResourceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResourceApi(Configuration configuration = null)
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
        /// List Resources
        /// </summary>
        /// <remarks>You can retrieve a list of resources</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ManagedResources</returns>
        public ManagedResources FindAll(bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResources> response = FindAllWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>You can retrieve a list of resources</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of ManagedResources</returns>
        public ApiResponse<ManagedResources> FindAllWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/resources";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResources)Configuration.ApiClient.Deserialize(response, typeof(ManagedResources)));
        }

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>You can retrieve a list of resources</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResources</returns>
        public async System.Threading.Tasks.Task<ManagedResources> FindAllAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResources> response = await FindAllAsyncWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Resources
        /// </summary>
        /// <remarks>You can retrieve a list of resources</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResources)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagedResources>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/resources";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAllAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAllAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResources)Configuration.ApiClient.Deserialize(response, typeof(ManagedResources)));
        }

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ManagedResources</returns>
        public ManagedResources FindAllByType(ResourceType type, bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResources> response = FindAllByTypeWithHttpInfo(type, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of ManagedResources</returns>
        public ApiResponse<ManagedResources> FindAllByTypeWithHttpInfo(ResourceType type, bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/resources/{type}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("type", Configuration.ApiClient.ParameterToString(type.ToString())); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAllByType: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAllByType: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResources)Configuration.ApiClient.Deserialize(response, typeof(ManagedResources)));
        }

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResources</returns>
        public async System.Threading.Tasks.Task<ManagedResources> FindAllByTypeAsync(ResourceType type, bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResources> response = await FindAllByTypeAsyncWithHttpInfo(type, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List resources by type
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of resources of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResources)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagedResources>> FindAllByTypeAsyncWithHttpInfo(ResourceType type, bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/resources/{type}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("type", Configuration.ApiClient.ParameterToString(type.ToString())); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAllByTypeAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAllByTypeAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResources)Configuration.ApiClient.Deserialize(response, typeof(ManagedResources)));
        }

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ManagedResources</returns>
        public ManagedResource FindSpecificByType(ResourceType type, string resourceId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResource> response = FindSpecificByTypeWithHttpInfo(type, resourceId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of ManagedResource</returns>
        public ApiResponse<ManagedResource> FindSpecificByTypeWithHttpInfo(ResourceType type, string resourceId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'resourceId' is set
            if (string.IsNullOrEmpty(resourceId))
                throw new ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->FindSpecificByType");

            var path_ = "/um/resources/{type}/{resourceId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("type", Configuration.ApiClient.ParameterToString(type.ToString())); // path parameter
            pathParams.Add("resourceId", Configuration.ApiClient.ParameterToString(resourceId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindSpecificByType: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindSpecificByType: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResource)Configuration.ApiClient.Deserialize(response, typeof(ManagedResource)));
        }

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ManagedResource</returns>
        public async System.Threading.Tasks.Task<ManagedResource> FindSpecificByTypeAsync(ResourceType type, string resourceId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<ManagedResource> response = await FindSpecificByTypeAsyncWithHttpInfo(type, resourceId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Find a resource of a type
        /// </summary>
        /// <remarks>
        /// Retrieves a specific resource of a particular type
        /// </remarks>
        /// <param name="type">Resource type to list</param>
        /// <param name="resourceId">The unique ID of the resource</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ManagedResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagedResource>> FindSpecificByTypeAsyncWithHttpInfo(ResourceType type, string resourceId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'resourceId' is set
            if (string.IsNullOrEmpty(resourceId))
                throw new ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->FindSpecificByType");

            var path_ = "/um/resources/{type}/{resourceId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("type", Configuration.ApiClient.ParameterToString(type.ToString())); // path parameter
            pathParams.Add("resourceId", Configuration.ApiClient.ParameterToString(resourceId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse)await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindSpecificByTypeAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindSpecificByTypeAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagedResource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagedResource)Configuration.ApiClient.Deserialize(response, typeof(ManagedResource)));
        }
    }
}
