// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations of Azure SQL Database Transparent Data
    /// Encryption.  Contains operations to: Retrieve, and Update Transparent
    /// Data Encryption.
    /// </summary>
    internal partial class TransparentDataEncryptionOperations : IServiceOperations<SqlManagementClient>, ITransparentDataEncryptionOperations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TransparentDataEncryptionOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal TransparentDataEncryptionOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Creates or updates an Azure SQL Database Transparent Data
        /// Encryption Operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which setting the
        /// Transparent Data Encryption applies.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating
        /// transparent data encryption.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get for a Azure Sql Database
        /// Transparent Data Encryption request.
        /// </returns>
        public async Task<TransparentDataEncryptionGetResponse> CreateOrUpdateAsync(string resourceGroupName, string serverName, string databaseName, TransparentDataEncryptionCreateOrUpdateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.Properties == null)
            {
                throw new ArgumentNullException("parameters.Properties");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "CreateOrUpdateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/transparentDataEncryption/current";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject transparentDataEncryptionCreateOrUpdateParametersValue = new JObject();
                requestDoc = transparentDataEncryptionCreateOrUpdateParametersValue;
                
                JObject propertiesValue = new JObject();
                transparentDataEncryptionCreateOrUpdateParametersValue["properties"] = propertiesValue;
                
                if (parameters.Properties.State != null)
                {
                    propertiesValue["status"] = parameters.Properties.State;
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    TransparentDataEncryptionGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new TransparentDataEncryptionGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            TransparentDataEncryption transparentDataEncryptionInstance = new TransparentDataEncryption();
                            result.TransparentDataEncryption = transparentDataEncryptionInstance;
                            
                            JToken propertiesValue2 = responseDoc["properties"];
                            if (propertiesValue2 != null && propertiesValue2.Type != JTokenType.Null)
                            {
                                TransparentDataEncryptionProperties propertiesInstance = new TransparentDataEncryptionProperties();
                                transparentDataEncryptionInstance.Properties = propertiesInstance;
                                
                                JToken statusValue = propertiesValue2["status"];
                                if (statusValue != null && statusValue.Type != JTokenType.Null)
                                {
                                    string statusInstance = ((string)statusValue);
                                    propertiesInstance.State = statusInstance;
                                }
                            }
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                transparentDataEncryptionInstance.Id = idInstance;
                            }
                            
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                transparentDataEncryptionInstance.Name = nameInstance;
                            }
                            
                            JToken typeValue = responseDoc["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                transparentDataEncryptionInstance.Type = typeInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                transparentDataEncryptionInstance.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    transparentDataEncryptionInstance.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns an Azure SQL Database Transparent Data Encryption Response.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the
        /// Transparent Data Encryption applies.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get for a Azure Sql Database
        /// Transparent Data Encryption request.
        /// </returns>
        public async Task<TransparentDataEncryptionGetResponse> GetAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/transparentDataEncryption/current";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    TransparentDataEncryptionGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new TransparentDataEncryptionGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            TransparentDataEncryption transparentDataEncryptionInstance = new TransparentDataEncryption();
                            result.TransparentDataEncryption = transparentDataEncryptionInstance;
                            
                            JToken propertiesValue = responseDoc["properties"];
                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                            {
                                TransparentDataEncryptionProperties propertiesInstance = new TransparentDataEncryptionProperties();
                                transparentDataEncryptionInstance.Properties = propertiesInstance;
                                
                                JToken statusValue = propertiesValue["status"];
                                if (statusValue != null && statusValue.Type != JTokenType.Null)
                                {
                                    string statusInstance = ((string)statusValue);
                                    propertiesInstance.State = statusInstance;
                                }
                            }
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                transparentDataEncryptionInstance.Id = idInstance;
                            }
                            
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                transparentDataEncryptionInstance.Name = nameInstance;
                            }
                            
                            JToken typeValue = responseDoc["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                transparentDataEncryptionInstance.Type = typeInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                transparentDataEncryptionInstance.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    transparentDataEncryptionInstance.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns an Azure SQL Database Transparent Data Encryption Activity
        /// Response.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the
        /// Transparent Data Encryption applies.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database Transparent
        /// Data Encryption Activity request.
        /// </returns>
        public async Task<TransparentDataEncryptionActivityListResponse> ListActivityAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                TracingAdapter.Enter(invocationId, this, "ListActivityAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/transparentDataEncryption/current/operationResults";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    TransparentDataEncryptionActivityListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new TransparentDataEncryptionActivityListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    TransparentDataEncryptionActivity transparentDataEncryptionActivityInstance = new TransparentDataEncryptionActivity();
                                    result.TransparentDataEncryptionActivities.Add(transparentDataEncryptionActivityInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        TransparentDataEncryptionActivityProperties propertiesInstance = new TransparentDataEncryptionActivityProperties();
                                        transparentDataEncryptionActivityInstance.Properties = propertiesInstance;
                                        
                                        JToken statusValue = propertiesValue["status"];
                                        if (statusValue != null && statusValue.Type != JTokenType.Null)
                                        {
                                            string statusInstance = ((string)statusValue);
                                            propertiesInstance.Status = statusInstance;
                                        }
                                        
                                        JToken percentCompleteValue = propertiesValue["percentComplete"];
                                        if (percentCompleteValue != null && percentCompleteValue.Type != JTokenType.Null)
                                        {
                                            float percentCompleteInstance = ((float)percentCompleteValue);
                                            propertiesInstance.PercentComplete = percentCompleteInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        transparentDataEncryptionActivityInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        transparentDataEncryptionActivityInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        transparentDataEncryptionActivityInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        transparentDataEncryptionActivityInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            transparentDataEncryptionActivityInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}