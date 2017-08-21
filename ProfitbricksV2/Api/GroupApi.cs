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
    public interface IGroupApi
    {
        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of groups
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Groups</returns>
        Groups FindAll(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of groups
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Groups</returns>
        ApiResponse<Groups> FindAllWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of groups
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Groups</returns>
        System.Threading.Tasks.Task<Groups> FindAllAsync(bool? parameter = null, int? depth = null);

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of groups
        /// </remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Groups)</returns>
        System.Threading.Tasks.Task<ApiResponse<Groups>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>
        /// Creates a group
        /// </remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Group</returns>
        Group Create(Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>
        /// Creates a group
        /// </remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Group</returns>
        ApiResponse<Group> CreateWithHttpInfo(Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>
        /// Creates a group
        /// </remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> CreateAsync(Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>
        /// Creates a group
        /// </remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<Group>> CreateAsyncWithHttpInfo(Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>
        /// Returns information about a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Group</returns>
        Group FindById(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>
        /// Returns information about a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Group</returns>
        ApiResponse<Group> FindByIdWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>
        /// Returns information about a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> FindByIdAsync(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>
        /// Returns information about a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<Group>> FindByIdAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Group</returns>
        Group Update(string groupId, Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Group</returns>
        ApiResponse<Group> UpdateWithHttpInfo(string groupId, Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> UpdateAsync(string groupId, Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>
        /// You can use update attributes of a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<Group>> UpdateAsyncWithHttpInfo(string groupId, Group group, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>
        /// This will delete a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 Delete(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>
        /// This will delete a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> DeleteWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>
        /// This will delete a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>
        /// This will delete a group
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Users</returns>
        Users FindAllGroupUsers(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Users</returns>
        ApiResponse<Users> FindAllGroupUsersWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Users</returns>
        System.Threading.Tasks.Task<Users> FindAllGroupUsersAsync(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        System.Threading.Tasks.Task<ApiResponse<Users>> FindAllGroupUsersAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>User</returns>
        User AddGroupUser(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> AddGroupUserWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> AddGroupUserAsync(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> AddGroupUserAsyncWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 RemoveGroupUser(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> RemoveGroupUserWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> RemoveGroupUserAsync(string groupId, string userId, bool? parameter = null, int? depth = null);

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> RemoveGroupUserAsyncWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GroupApi : IGroupApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GroupApi(Configuration configuration = null)
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
        /// List Groups
        /// </summary>
        /// <remarks>You can retrieve a list of groups</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Groups</returns>
        public Groups FindAll(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Groups> response = FindAllWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>You can retrieve a list of groups</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Groups</returns>
        public ApiResponse<Groups> FindAllWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/groups";

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

            return new ApiResponse<Groups>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Groups)Configuration.ApiClient.Deserialize(response, typeof(Groups)));

        }

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>You can retrieve a list of groups</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Groups</returns>
        public async System.Threading.Tasks.Task<Groups> FindAllAsync(bool? parameter = null, int? depth = null)
        {
            ApiResponse<Groups> response = await FindAllAsyncWithHttpInfo(parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List Groups
        /// </summary>
        /// <remarks>You can retrieve a list of groups</remarks>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Groups)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Groups>> FindAllAsyncWithHttpInfo(bool? parameter = null, int? depth = null)
        {
            var path_ = "/um/groups";

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

            return new ApiResponse<Groups>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Groups)Configuration.ApiClient.Deserialize(response, typeof(Groups)));

        }

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>You can create a group</remarks>
        /// <param name="group">Group to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Group</returns>
        public Group Create(Group group, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = CreateWithHttpInfo(group, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>You can create a group</remarks>
        /// <param name="group">Group to be created</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Group</returns>
        public ApiResponse<Group> CreateWithHttpInfo(Group group, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'group' is set
            if (group == null)
                throw new ApiException(400, "Missing required parameter 'group' when calling GroupApi->Create");

            var path_ = "/um/groups";

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

            if (group.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(group); // http body (model) parameter
            }
            else
            {
                postBody = group; // byte array
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

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));
        }

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>You can create a group</remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> CreateAsync(Group group, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = await CreateAsyncWithHttpInfo(group, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Create a Group
        /// </summary>
        /// <remarks>You can create a group</remarks>
        /// <param name="group">Group to be created</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Group>> CreateAsyncWithHttpInfo(Group group, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Create");

            var path_ = "/um/groups";

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

            postBody = Configuration.ApiClient.Serialize(group); // http body (model) parameter

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

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));

        }

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>Returns information about a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Group</returns>
        public Group FindById(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = FindByIdWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>Returns information about a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Group</returns>
        public ApiResponse<Group> FindByIdWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->FindById");

            var path_ = "/um/groups/{groupId}";

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
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));
        }

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>Returns information about a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> FindByIdAsync(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = await FindByIdAsyncWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Retrieve a Group
        /// </summary>
        /// <remarks>Returns information about a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Group>> FindByIdAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling FindById");

            var path_ = "/um/groups/{groupId}";

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
                throw new ApiException(statusCode, "Error calling FindById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindById: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));
        }

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>You can update attributes of a group</remarks>
        /// <param name="groupId">The unique ID of the group</param> 
        /// <param name="group">Modified Group</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>Group</returns>
        public Group Update(string groupId, Group group, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = UpdateWithHttpInfo(groupId, group, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>You can update attributes of a group</remarks>
        /// <param name="groupId">The unique ID of the group</param> 
        /// <param name="group">Modified Group</param> 
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of Group</returns>
        public ApiResponse<Group> UpdateWithHttpInfo(string groupId, Group group, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->Update");

            // verify the required parameter 'group' is set
            if (group == null)
                throw new ApiException(400, "Missing required parameter 'group' when calling GroupApi->Update");

            var path_ = "/um/groups/{groupId}";

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

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            if (group.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(group); // http body (model) parameter
            }
            else
            {
                postBody = group; // byte array
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

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));
        }

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>You can update attributes of a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> UpdateAsync(string groupId, Group group, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Group> response = await UpdateAsyncWithHttpInfo(groupId, group, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Modify a Group
        /// </summary>
        /// <remarks>You can update attributes of a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="group">Modified Group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Group>> UpdateAsyncWithHttpInfo(string groupId, Group group, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling Update");
            // verify the required parameter 'group' is set
            if (group == null)
                throw new ApiException(400, "Missing required parameter 'group' when calling Update");

            var path_ = "/um/groups/{groupId}";

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

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            postBody = Configuration.ApiClient.Serialize(group); // http body (model) parameter

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

            return new ApiResponse<Group>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Group)Configuration.ApiClient.Deserialize(response, typeof(Group)));
        }

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>This will delete a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 Delete(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = DeleteWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>This will delete a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param> 
        /// <param name="depth">Controls the details depth of response objects.</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> DeleteWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->Delete");

            var path_ = "/um/groups/{groupId}";

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
        /// Delete a Group
        /// </summary>
        /// <remarks>This will delete a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> DeleteAsync(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await DeleteAsyncWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Delete a Group
        /// </summary>
        /// <remarks>This will delete a group</remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> DeleteAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling Delete");

            var path_ = "/um/groups/{groupId}";

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
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Users</returns>
        public Users FindAllGroupUsers(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Users> response = FindAllGroupUsersWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of Users</returns>
        public ApiResponse<Users> FindAllGroupUsersWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->FindAllGroupUsers");

            var path_ = "/um/groups/{groupId}/users";

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
                throw new ApiException(statusCode, "Error calling FindAllGroupUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAllGroupUsers: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Users>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Users)Configuration.ApiClient.Deserialize(response, typeof(Users)));
        }

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of Users</returns>
        public async System.Threading.Tasks.Task<Users> FindAllGroupUsersAsync(string groupId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<Users> response = await FindAllGroupUsersAsyncWithHttpInfo(groupId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// List group users
        /// </summary>
        /// <remarks>
        /// You can retrieve a list of group users
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Users>> FindAllGroupUsersAsyncWithHttpInfo(string groupId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling FindAllGroupUsersAsync");

            var path_ = "/um/groups/{groupId}/users";

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
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling FindAllGroupUsersAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling FindAllGroupUsersAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Users>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Users)Configuration.ApiClient.Deserialize(response, typeof(Users)));
        }

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>User</returns>
        public User AddGroupUser(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = AddGroupUserWithHttpInfo(groupId, userId, parameter, depth);
            response.Data.Request = response.Headers["Location"];
            return response.Data;
        }

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> AddGroupUserWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling AddGroupUser");
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling AddGroupUser");

            var path_ = "/um/groups/{groupId}/users";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // Serialize anonymous type
            Object postBody = Configuration.ApiClient.Serialize(new { id = userId });

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
                throw new ApiException(statusCode, "Error calling AddGroupUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AddGroupUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> AddGroupUserAsync(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<User> response = await AddGroupUserAsyncWithHttpInfo(groupId, userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <remarks>
        /// Use this operation to add an existing user to a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> AddGroupUserAsyncWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling AddGroupUser");
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling AddGroupUser");

            var path_ = "/um/groups/{groupId}/users";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            if (depth != null) queryParams.Add("depth", Configuration.ApiClient.ParameterToString(depth)); // query parameter

            // Serialize anonymous type
            Object postBody = Configuration.ApiClient.Serialize(new { id = userId });

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
                throw new ApiException(statusCode, "Error calling AddGroupUserAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AddGroupUserAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User)Configuration.ApiClient.Deserialize(response, typeof(User)));
        }

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 RemoveGroupUser(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = RemoveGroupUserWithHttpInfo(groupId, userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse<InlineResponse202> RemoveGroupUserWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling RemoveGroupUser");
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveGroupUser");

            var path_ = "/um/groups/{groupId}/users/{userId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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
                Method.DELETE, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling RemoveGroupUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling RemoveGroupUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> RemoveGroupUserAsync(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            ApiResponse<InlineResponse202> response = await RemoveGroupUserAsyncWithHttpInfo(groupId, userId, parameter, depth);
            return response.Data;
        }

        /// <summary>
        /// Remove user from group
        /// </summary>
        /// <remarks>
        /// Use this operation to remove a user from a group.
        /// </remarks>
        /// <param name="groupId">The unique ID of the group</param>
        /// <param name="userId">The unique ID of the user</param>
        /// <param name="parameter">Controls whether response is pretty-printed (with indentation and new lines)</param>
        /// <param name="depth">Controls the details depth of response objects.</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> RemoveGroupUserAsyncWithHttpInfo(string groupId, string userId, bool? parameter = null, int? depth = null)
        {
            // verify the required parameter 'groupId' is set
            if (string.IsNullOrEmpty(groupId))
                throw new ApiException(400, "Missing required parameter 'groupId' when calling RemoveGroupUser");
            // verify the required parameter 'userId' is set
            if (string.IsNullOrEmpty(userId))
                throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveGroupUser");

            var path_ = "/um/groups/{groupId}/users/{userId}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

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
            pathParams.Add("format", "json");
            pathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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
                Method.DELETE, queryParams, null, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling RemoveGroupUserAsync: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling RemoveGroupUserAsync: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202)Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
        }
    }
}
