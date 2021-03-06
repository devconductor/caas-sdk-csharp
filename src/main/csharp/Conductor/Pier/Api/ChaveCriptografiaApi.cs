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
    public interface IChaveCriptografiaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Recurso para consultar a chave de criptografia AES.
        /// </summary>
        /// <remarks>
        /// O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChaveCriptografiaResponse</returns>
        ChaveCriptografiaResponse ConsultarChaveCriptografia ();
  
        /// <summary>
        /// Recurso para consultar a chave de criptografia AES.
        /// </summary>
        /// <remarks>
        /// O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChaveCriptografiaResponse</returns>
        ApiResponse<ChaveCriptografiaResponse> ConsultarChaveCriptografiaWithHttpInfo ();
        
        /// <summary>
        /// Descriptografa o conteudo recebido
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>ChaveCriptografiaResponse</returns>
        ChaveCriptografiaResponse DescriptografarChave (ChaveCriptografiaRequest chaveCriptografiaRequest);
  
        /// <summary>
        /// Descriptografa o conteudo recebido
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>ApiResponse of ChaveCriptografiaResponse</returns>
        ApiResponse<ChaveCriptografiaResponse> DescriptografarChaveWithHttpInfo (ChaveCriptografiaRequest chaveCriptografiaRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Recurso para consultar a chave de criptografia AES.
        /// </summary>
        /// <remarks>
        /// O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChaveCriptografiaResponse</returns>
        System.Threading.Tasks.Task<ChaveCriptografiaResponse> ConsultarChaveCriptografiaAsync ();

        /// <summary>
        /// Recurso para consultar a chave de criptografia AES.
        /// </summary>
        /// <remarks>
        /// O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChaveCriptografiaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChaveCriptografiaResponse>> ConsultarChaveCriptografiaAsyncWithHttpInfo ();
        
        /// <summary>
        /// Descriptografa o conteudo recebido
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>Task of ChaveCriptografiaResponse</returns>
        System.Threading.Tasks.Task<ChaveCriptografiaResponse> DescriptografarChaveAsync (ChaveCriptografiaRequest chaveCriptografiaRequest);

        /// <summary>
        /// Descriptografa o conteudo recebido
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>Task of ApiResponse (ChaveCriptografiaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChaveCriptografiaResponse>> DescriptografarChaveAsyncWithHttpInfo (ChaveCriptografiaRequest chaveCriptografiaRequest);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChaveCriptografiaApi : IChaveCriptografiaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveCriptografiaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChaveCriptografiaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveCriptografiaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChaveCriptografiaApi(Configuration configuration = null)
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
        /// Recurso para consultar a chave de criptografia AES. O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChaveCriptografiaResponse</returns>
        public ChaveCriptografiaResponse ConsultarChaveCriptografia ()
        {
             ApiResponse<ChaveCriptografiaResponse> localVarResponse = ConsultarChaveCriptografiaWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recurso para consultar a chave de criptografia AES. O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChaveCriptografiaResponse</returns>
        public ApiResponse< ChaveCriptografiaResponse > ConsultarChaveCriptografiaWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/criptografia/chave";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarChaveCriptografia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarChaveCriptografia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ChaveCriptografiaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChaveCriptografiaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChaveCriptografiaResponse)));
            
        }

        
        /// <summary>
        /// Recurso para consultar a chave de criptografia AES. O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChaveCriptografiaResponse</returns>
        public async System.Threading.Tasks.Task<ChaveCriptografiaResponse> ConsultarChaveCriptografiaAsync ()
        {
             ApiResponse<ChaveCriptografiaResponse> localVarResponse = await ConsultarChaveCriptografiaAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recurso para consultar a chave de criptografia AES. O recurso retorna a chave AES criptografada com a chave p\u00FAblica do emissor relacionado ao token da requisi\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChaveCriptografiaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChaveCriptografiaResponse>> ConsultarChaveCriptografiaAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/criptografia/chave";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarChaveCriptografia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarChaveCriptografia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChaveCriptografiaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChaveCriptografiaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChaveCriptografiaResponse)));
            
        }
        
        /// <summary>
        /// Descriptografa o conteudo recebido Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param> 
        /// <returns>ChaveCriptografiaResponse</returns>
        public ChaveCriptografiaResponse DescriptografarChave (ChaveCriptografiaRequest chaveCriptografiaRequest)
        {
             ApiResponse<ChaveCriptografiaResponse> localVarResponse = DescriptografarChaveWithHttpInfo(chaveCriptografiaRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Descriptografa o conteudo recebido Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param> 
        /// <returns>ApiResponse of ChaveCriptografiaResponse</returns>
        public ApiResponse< ChaveCriptografiaResponse > DescriptografarChaveWithHttpInfo (ChaveCriptografiaRequest chaveCriptografiaRequest)
        {
            
            // verify the required parameter 'chaveCriptografiaRequest' is set
            if (chaveCriptografiaRequest == null)
                throw new ApiException(400, "Missing required parameter 'chaveCriptografiaRequest' when calling ChaveCriptografiaApi->DescriptografarChave");
            
    
            var localVarPath = "/api/chaves-criptografia/descriptografar";
    
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
            
            
            
            
            if (chaveCriptografiaRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(chaveCriptografiaRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = chaveCriptografiaRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DescriptografarChave: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DescriptografarChave: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ChaveCriptografiaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChaveCriptografiaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChaveCriptografiaResponse)));
            
        }

        
        /// <summary>
        /// Descriptografa o conteudo recebido Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>Task of ChaveCriptografiaResponse</returns>
        public async System.Threading.Tasks.Task<ChaveCriptografiaResponse> DescriptografarChaveAsync (ChaveCriptografiaRequest chaveCriptografiaRequest)
        {
             ApiResponse<ChaveCriptografiaResponse> localVarResponse = await DescriptografarChaveAsyncWithHttpInfo(chaveCriptografiaRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Descriptografa o conteudo recebido Este m\u00E9todo realiza a descriptografia de conteudos no padr\u00E3o BouncyCastle
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chaveCriptografiaRequest">chaveCriptografiaRequest</param>
        /// <returns>Task of ApiResponse (ChaveCriptografiaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChaveCriptografiaResponse>> DescriptografarChaveAsyncWithHttpInfo (ChaveCriptografiaRequest chaveCriptografiaRequest)
        {
            // verify the required parameter 'chaveCriptografiaRequest' is set
            if (chaveCriptografiaRequest == null) throw new ApiException(400, "Missing required parameter 'chaveCriptografiaRequest' when calling DescriptografarChave");
            
    
            var localVarPath = "/api/chaves-criptografia/descriptografar";
    
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
            
            
            
            
            if (chaveCriptografiaRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(chaveCriptografiaRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = chaveCriptografiaRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DescriptografarChave: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DescriptografarChave: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChaveCriptografiaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChaveCriptografiaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChaveCriptografiaResponse)));
            
        }
        
    }
    
}
