using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Pier.Client;
using Conductor.Pier.Model;

namespace Conductor.Pier.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILimitApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoEventosResponse</returns>
        PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        ApiResponse<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LimitApi : ILimitApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LimitApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LimitApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

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
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoEventosResponse</returns>
        public PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = ListarHistoricoAlteracoesLimitesWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        public ApiResponse< PageHistoricoEventosResponse > ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LimitApi->ListarHistoricoAlteracoesLimites");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }

        
        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = await ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAlteracoesLimites");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }
        
    }
    
}
