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
    public interface IImageApi
    {

        /// <summary>
        /// List Images
        /// </summary>
        /// <remarks>
        /// Retrieve a list of images within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Images</returns>
        Images FindAll(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Images
        /// </summary>
        /// <remarks>
        /// Retrieve a list of images within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Images</returns>
        ApiResponse<Images> FindAllWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Images
        /// </summary>
        /// <remarks>
        /// Retrieve a list of images within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Images</returns>
        System.Threading.Tasks.Task<Images> FindAllAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Images
        /// </summary>
        /// <remarks>
        /// Retrieve a list of images within the datacenter
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Images)</returns>
        System.Threading.Tasks.Task<ApiResponse<Images>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an Image
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given image.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Image</returns>
        Image FindById(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an Image
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given image.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Image</returns>
        ApiResponse<Image> FindByIdWithHttpInfo(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an Image
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given image.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        System.Threading.Tasks.Task<Image> FindByIdAsync(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve an Image
        /// </summary>
        /// <remarks>
        /// Retrieves the attributes of a given image.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        System.Threading.Tasks.Task<ApiResponse<Image>> FindByIdAsyncWithHttpInfo(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Image</returns>
        Image Update(string imageId, Image image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Image</returns>
        ApiResponse<Image> UpdateWithHttpInfo(string imageId, Image image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        System.Threading.Tasks.Task<Image> UpdateAsync(string imageId, Image image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        System.Threading.Tasks.Task<ApiResponse<Image>> UpdateAsyncWithHttpInfo(string imageId, Image image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete an Image
        /// </summary>
        /// <remarks>
        /// Deletes the specified image. This operation is permitted on private image only.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete an Image
        /// </summary>
        /// <remarks>
        /// Deletes the specified image. This operation is permitted on private image only.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete an Image
        /// </summary>
        /// <remarks>
        /// Deletes the specified image. This operation is permitted on private image only.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete an Image
        /// </summary>
        /// <remarks>
        /// Deletes the specified image. This operation is permitted on private image only.
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string imageId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Image</returns>
        Image PartialUpdate(string imageId, ImageProperties image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>ApiResponse of Image</returns>
        ApiResponse<Image> PartialUpdateWithHttpInfo(string imageId, ImageProperties image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        System.Threading.Tasks.Task<Image> PartialUpdateAsync(string imageId, ImageProperties image, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Partially modify an Image
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a resource
        /// </remarks>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        System.Threading.Tasks.Task<ApiResponse<Image>> PartialUpdateAsyncWithHttpInfo(string imageId, ImageProperties image, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ImageApi : IImageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImageApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImageApi(Configuration configuration = null)
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
        /// List Images Retrieve a list of images within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Images</returns>
        public Images FindAll(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Images> response = FindAllWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Images Retrieve a list of images within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Images</returns>
        public ApiResponse<Images> FindAllWithHttpInfo(bool? parameter = null, int? depth = null)
        {


            var path_ = "/images";

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

            return new ApiResponse<Images>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Images)Configuration.ApiClient.Deserialize(response, typeof(Images)));

        }

        /// <summary>
        /// List Images Retrieve a list of images within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Images</returns>
        public async System.Threading.Tasks.Task<Images> FindAllAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Images> response = await FindAllAsyncWithHttpInfo(parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// List Images Retrieve a list of images within the datacenter
        /// </summary>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Images)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Images>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {


            var path_ = "/images";

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

            return new ApiResponse<Images>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Images)Configuration.ApiClient.Deserialize(response, typeof(Images)));

        }

        /// <summary>
        /// Retrieve an Image Retrieves the attributes of a given image.
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Image</returns>
        public Image FindById(string imageId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = FindByIdWithHttpInfo(imageId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve an Image Retrieves the attributes of a given image.
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Image</returns>
        public ApiResponse<Image> FindByIdWithHttpInfo(string imageId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'imageId' is set
            if (imageId == null)
                throw new ApiException(400, "Missing required parameter 'imageId' when calling ImageApi->FindById");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

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
        /// Retrieve an Image Retrieves the attributes of a given image.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        public async System.Threading.Tasks.Task<Image> FindByIdAsync(string imageId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = await FindByIdAsyncWithHttpInfo(imageId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Retrieve an Image Retrieves the attributes of a given image.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Image>> FindByIdAsyncWithHttpInfo(string imageId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'imageId' is set
            if (imageId == null) throw new ApiException(400, "Missing required parameter 'imageId' when calling FindById");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

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
        /// Modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="image">Modified Image</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Image</returns>
        public Image Update(string imageId, Image image, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = UpdateWithHttpInfo(imageId, image, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="image">Modified Image</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Image</returns>
        public ApiResponse<Image> UpdateWithHttpInfo(string imageId, Image image, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'imageId' is set
            if (imageId == null)
                throw new ApiException(400, "Missing required parameter 'imageId' when calling ImageApi->Update");

            // verify the required parameter 'image' is set
            if (image == null)
                throw new ApiException(400, "Missing required parameter 'image' when calling ImageApi->Update");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (image.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter
            }
            else
            {
                postBody = image; // byte array
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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        public async System.Threading.Tasks.Task<Image> UpdateAsync(string imageId, Image image, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = await UpdateAsyncWithHttpInfo(imageId, image, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Image>> UpdateAsyncWithHttpInfo(string imageId, Image image, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'imageId' is set
            if (imageId == null) throw new ApiException(400, "Missing required parameter 'imageId' when calling Update");
            // verify the required parameter 'image' is set
            if (image == null) throw new ApiException(400, "Missing required parameter 'image' when calling Update");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter



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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Delete an Image Deletes the specified image. This operation is permitted on private image only.
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string imageId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(imageId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete an Image Deletes the specified image. This operation is permitted on private image only.
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string imageId, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'imageId' is set
            if (imageId == null)
                throw new ApiException(400, "Missing required parameter 'imageId' when calling ImageApi->Delete");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

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
        /// Delete an Image Deletes the specified image. This operation is permitted on private image only.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string imageId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(imageId, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Delete an Image Deletes the specified image. This operation is permitted on private image only.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string imageId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'imageId' is set
            if (imageId == null) throw new ApiException(400, "Missing required parameter 'imageId' when calling Delete");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

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
        /// Partially modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="image">Modified Image</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>Image</returns>
        public Image PartialUpdate(string imageId, ImageProperties image, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = PartialUpdateWithHttpInfo(imageId, image, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Partially modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param> 
        /// <param name="image">Modified Image</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param> 
        /// <returns>ApiResponse of Image</returns>
        public ApiResponse<Image> PartialUpdateWithHttpInfo(string imageId, ImageProperties image, bool? parameter = null, int? depth = null)
        {

            // verify the required parameter 'imageId' is set
            if (imageId == null)
                throw new ApiException(400, "Missing required parameter 'imageId' when calling ImageApi->PartialUpdate");

            // verify the required parameter 'image' is set
            if (image == null)
                throw new ApiException(400, "Missing required parameter 'image' when calling ImageApi->PartialUpdate");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            if (image.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter
            }
            else
            {
                postBody = image; // byte array
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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

        /// <summary>
        /// Partially modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of Image</returns>
        public async System.Threading.Tasks.Task<Image> PartialUpdateAsync(string imageId, ImageProperties image, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Image> response = await PartialUpdateAsyncWithHttpInfo(imageId, image, parameter, depth);
            return response.Data;

        }

        /// <summary>
        /// Partially modify an Image You can use update attributes of a resource
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="image">Modified Image</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects. \nEg. GET /datacenters/[ID]\n	- depth=0: only direct properties are included. Children (servers etc.) are not included\n	- depth=1: direct properties and children references are included\n	- depth=2: direct properties and children properties are included\n	- depth=3: direct properties and children properties and children&#39;s children are included\n	- depth=... and so on</param>
        /// <returns>Task of ApiResponse (Image)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Image>> PartialUpdateAsyncWithHttpInfo(string imageId, ImageProperties image, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'imageId' is set
            if (imageId == null) throw new ApiException(400, "Missing required parameter 'imageId' when calling PartialUpdate");
            // verify the required parameter 'image' is set
            if (image == null) throw new ApiException(400, "Missing required parameter 'image' when calling PartialUpdate");


            var path_ = "/images/{imageId}";

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
            if (imageId != null) pathParams.Add("imageId", Configuration.ApiClient.ParameterToString(imageId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter



            postBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter



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

            return new ApiResponse<Image>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Image)Configuration.ApiClient.Deserialize(response, typeof(Image)));

        }

    }

}