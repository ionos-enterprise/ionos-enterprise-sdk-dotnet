using Client;
using Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api
{
    public interface IContractResourcesApi
    {
        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ContractResources</returns>
        ContractResources List(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of ContractResources</returns>
        ApiResponse<ContractResources> ListWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ContractResources</returns>
        System.Threading.Tasks.Task<ContractResources> ListAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ContractResources)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractResources>> ListAsyncWithHttpInfo(bool? parameter = null, int? depth = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContractResourcesApi : IContractResourcesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractResourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContractResourcesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractResourcesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContractResourcesApi(Configuration configuration = null)
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
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ContractResources</returns>
        public ContractResources List(bool? parameter = null, int? depth = null)
        {
            ApiResponse<ContractResources> response = ListWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of ContractResources</returns>
        public ApiResponse<ContractResources> ListWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/contracts";

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
                throw new ApiException(statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContractResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractResources)Configuration.ApiClient.Deserialize(response, typeof(ContractResources)));

        }

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ContractResources</returns>
        public async System.Threading.Tasks.Task<ContractResources> ListAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<ContractResources> response = await ListAsyncWithHttpInfo(parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Contract Resources
        /// </summary>
        /// <remarks>
        /// Retrieve contract resources.
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed.</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (ContractResources)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractResources>> ListAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/contracts";

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
                throw new ApiException(statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContractResources>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractResources)Configuration.ApiClient.Deserialize(response, typeof(ContractResources)));

        }
    }
}
