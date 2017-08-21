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
    public interface IUserApi
    {
        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of users
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Users</returns>
        Users FindAll(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of users
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Users</returns>
        ApiResponse<Users> FindAllWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of users
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Users</returns>
        System.Threading.Tasks.Task<Users> FindAllAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of users
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        System.Threading.Tasks.Task<ApiResponse<Users>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>
        /// Creates a user
        /// </remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>User</returns>
        User Create(User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>
        /// Creates a user
        /// </remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> CreateWithHttpInfo(User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>
        /// Creates a user
        /// </remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> CreateAsync(User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>
        /// Creates a user
        /// </remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> CreateAsyncWithHttpInfo(User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>
        /// Returns information about a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>User</returns>
        User FindById(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>
        /// Returns information about a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> FindByIdWithHttpInfo(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>
        /// Returns information about a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> FindByIdAsync(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>
        /// Returns information about a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> FindByIdAsyncWithHttpInfo(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a user
        /// </remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>User</returns>
        User Update(string userId, User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a user
        /// </remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpdateWithHttpInfo(string userId, User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a user
        /// </remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpdateAsync(string userId, User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a user
        /// </remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpdateAsyncWithHttpInfo(string userId, User user, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>
        /// This will delete a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>
        /// This will delete a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>
        /// This will delete a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>
        /// This will delete a user
        /// </remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string userId, bool? parameter = null, int? depth = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
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
        /// List Users
        /// </summary>
        /// <remarks>You can retrieve a list of users</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Users</returns>
        public Users FindAll(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Users> response = FindAllWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>You can retrieve a list of users</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Users</returns>
        public ApiResponse<Users> FindAllWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/users";

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
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Users>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Users)Configuration.ApiClient.Deserialize(response, typeof(Users)));

        }

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>You can retrieve a list of users</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Users</returns>
        public async System.Threading.Tasks.Task<Users> FindAllAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Users> response = await FindAllAsyncWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>You can retrieve a list of users</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Users>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/users";

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
                throw new ApiException(statusCode, "Error calling FindAll: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAll: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Users>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Users)Configuration.ApiClient.Deserialize(response, typeof(Users)));
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>You can create a user</remarks>
        /// <param name="user">User to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>User</returns>
        public User Create(User user, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = CreateWithHttpInfo(user, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>You can create a user</remarks>
        /// <param name="user">User to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> CreateWithHttpInfo(User user, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new ApiException(400, "Missing required parameter 'user' when calling UserApi->Create");

            var path_ = "/um/users";

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

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            if (user.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter
            }
            else
            {
                postBody = user; // byte array
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
                throw new ApiException(statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>You can create a user</remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> CreateAsync(User user, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = await CreateAsyncWithHttpInfo(user, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <remarks>You can create a user</remarks>
        /// <param name="user">User to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> CreateAsyncWithHttpInfo(User user, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling Create");

            var path_ = "/um/users";

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

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter

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

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));

        }

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>Returns information about a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>User</returns>
        public User FindById(string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = FindByIdWithHttpInfo(userId, parameter, depth);

            return response.Data;
        }

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>Returns information about a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> FindByIdWithHttpInfo(string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->FindById");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>Returns information about a user</remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> FindByIdAsync(string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = await FindByIdAsyncWithHttpInfo(userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>Returns information about a user</remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> FindByIdAsyncWithHttpInfo(string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling FindById");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>You can update attributes of a user</remarks>
        /// <param name="userId">The unique ID of the user</param> 
        /// <param name="user">Modified User</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>User</returns>
        public User Update(string userId, User user, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = UpdateWithHttpInfo(userId, user, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>You can update attributes of a user</remarks>
        /// <param name="userId">The unique ID of the user</param> 
        /// <param name="user">Modified User</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> UpdateWithHttpInfo(string userId, User user, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->Update");

            // verify the required parameter 'user' is set
            if (user == null)
                throw new ApiException(400, "Missing required parameter 'user' when calling UserApi->Update");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            if (user.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter
            }
            else
            {
                postBody = user; // byte array
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

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>You can update attributes of a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpdateAsync(string userId, User user, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = await UpdateAsyncWithHttpInfo(userId, user, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a User
        /// </summary>
        /// <remarks>You can update attributes of a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="user">Modified User</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpdateAsyncWithHttpInfo(string userId, User user, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling Update");
            // verify the required parameter 'user' is set
            if (user == null)
                throw new ApiException(400, "Missing required parameter 'user' when calling Update");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter

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

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>This will delete a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>This will delete a user</remarks>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->Delete");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>This will delete a user</remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <remarks>This will delete a user</remarks>
        /// <param name="userId"></param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling Delete");

            var path_ = "/um/users/{userId}";

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
            pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                throw new ApiException(statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }
    }
}
