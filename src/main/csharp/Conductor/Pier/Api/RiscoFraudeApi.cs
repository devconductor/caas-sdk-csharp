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
    public interface IRiscoFraudeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Object</returns>
        Object NegarRiscoFraude (long? id);
  
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> NegarRiscoFraudeWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Object</returns>
        Object ReconhecerRiscoFraude (long? id);
  
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReconhecerRiscoFraudeWithHttpInfo (long? id);
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object ValidarPortadorRiscoFraude (DadosPortadorRequest request);
  
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarPortadorRiscoFraudeWithHttpInfo (DadosPortadorRequest request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> NegarRiscoFraudeAsync (long? id);

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NegarRiscoFraudeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReconhecerRiscoFraudeAsync (long? id);

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReconhecerRiscoFraudeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarPortadorRiscoFraudeAsync (DadosPortadorRequest request);

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarPortadorRiscoFraudeAsyncWithHttpInfo (DadosPortadorRequest request);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RiscoFraudeApi : IRiscoFraudeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RiscoFraudeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RiscoFraudeApi(Configuration configuration = null)
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
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>Object</returns>
        public Object NegarRiscoFraude (long? id)
        {
             ApiResponse<Object> localVarResponse = NegarRiscoFraudeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > NegarRiscoFraudeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->NegarRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/negar";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NegarRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NegarRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> NegarRiscoFraudeAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await NegarRiscoFraudeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> NegarRiscoFraudeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling NegarRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/negar";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NegarRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NegarRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>Object</returns>
        public Object ReconhecerRiscoFraude (long? id)
        {
             ApiResponse<Object> localVarResponse = ReconhecerRiscoFraudeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReconhecerRiscoFraudeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->ReconhecerRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/reconhecer";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReconhecerRiscoFraudeAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReconhecerRiscoFraudeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReconhecerRiscoFraudeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReconhecerRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/reconhecer";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object ValidarPortadorRiscoFraude (DadosPortadorRequest request)
        {
             ApiResponse<Object> localVarResponse = ValidarPortadorRiscoFraudeWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarPortadorRiscoFraudeWithHttpInfo (DadosPortadorRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling RiscoFraudeApi->ValidarPortadorRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/validar-dados-portador";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarPortadorRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarPortadorRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarPortadorRiscoFraudeAsync (DadosPortadorRequest request)
        {
             ApiResponse<Object> localVarResponse = await ValidarPortadorRiscoFraudeAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarPortadorRiscoFraudeAsyncWithHttpInfo (DadosPortadorRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarPortadorRiscoFraude");
            
    
            var localVarPath = "/api/riscos-fraudes/validar-dados-portador";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarPortadorRiscoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarPortadorRiscoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
