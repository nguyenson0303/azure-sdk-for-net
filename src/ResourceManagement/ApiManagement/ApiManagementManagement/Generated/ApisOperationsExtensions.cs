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
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public static partial class ApisOperationsExtensions
    {
        /// <summary>
        /// Creates new or updates existing specific API of the Api Management
        /// service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update parameters.
        /// </param>
        /// <param name='etag'>
        /// Optional. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse CreateOrUpdate(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, ApiCreateOrUpdateParameters parameters, string etag)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).CreateOrUpdateAsync(resourceGroupName, serviceName, aid, parameters, etag);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates new or updates existing specific API of the Api Management
        /// service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update parameters.
        /// </param>
        /// <param name='etag'>
        /// Optional. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateOrUpdateAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, ApiCreateOrUpdateParameters parameters, string etag)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, aid, parameters, etag, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string etag)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).DeleteAsync(resourceGroupName, serviceName, aid, etag);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string etag)
        {
            return operations.DeleteAsync(resourceGroupName, serviceName, aid, etag, CancellationToken.None);
        }
        
        /// <summary>
        /// Exporst API to one of the supported formats.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='accept'>
        /// Required. Type of exporting content. Equivalent to Accept HTTP
        /// header.
        /// </param>
        /// <returns>
        /// The response model for the export API output operation.
        /// </returns>
        public static ApiExportResponse Export(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string accept)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).ExportAsync(resourceGroupName, serviceName, aid, accept);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Exporst API to one of the supported formats.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='accept'>
        /// Required. Type of exporting content. Equivalent to Accept HTTP
        /// header.
        /// </param>
        /// <returns>
        /// The response model for the export API output operation.
        /// </returns>
        public static Task<ApiExportResponse> ExportAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string accept)
        {
            return operations.ExportAsync(resourceGroupName, serviceName, aid, accept, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <returns>
        /// Get Api operation response details.
        /// </returns>
        public static ApiGetResponse Get(this IApisOperations operations, string resourceGroupName, string serviceName, string aid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).GetAsync(resourceGroupName, serviceName, aid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <returns>
        /// Get Api operation response details.
        /// </returns>
        public static Task<ApiGetResponse> GetAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid)
        {
            return operations.GetAsync(resourceGroupName, serviceName, aid, CancellationToken.None);
        }
        
        /// <summary>
        /// Imports API from one of the supported formats.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='contentType'>
        /// Required. Type of importing content.
        /// </param>
        /// <param name='content'>
        /// Required. Importing content.
        /// </param>
        /// <param name='path'>
        /// Optional. Path in case importing document does not support path.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Import(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string contentType, Stream content, string path)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).ImportAsync(resourceGroupName, serviceName, aid, contentType, content, path);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Imports API from one of the supported formats.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='contentType'>
        /// Required. Type of importing content.
        /// </param>
        /// <param name='content'>
        /// Required. Importing content.
        /// </param>
        /// <param name='path'>
        /// Optional. Path in case importing document does not support path.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> ImportAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, string contentType, Stream content, string path)
        {
            return operations.ImportAsync(resourceGroupName, serviceName, aid, contentType, content, path, CancellationToken.None);
        }
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        public static ApiListResponse List(this IApisOperations operations, string resourceGroupName, string serviceName, QueryParameters query)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).ListAsync(resourceGroupName, serviceName, query);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        public static Task<ApiListResponse> ListAsync(this IApisOperations operations, string resourceGroupName, string serviceName, QueryParameters query)
        {
            return operations.ListAsync(resourceGroupName, serviceName, query, CancellationToken.None);
        }
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        public static ApiListResponse ListNext(this IApisOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        public static Task<ApiListResponse> ListNextAsync(this IApisOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Patches specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Required. Patch parameters.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Patch(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, PatchParameters parameters, string etag)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IApisOperations)s).PatchAsync(resourceGroupName, serviceName, aid, parameters, etag);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Patches specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IApisOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Required. Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Required. Patch parameters.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> PatchAsync(this IApisOperations operations, string resourceGroupName, string serviceName, string aid, PatchParameters parameters, string etag)
        {
            return operations.PatchAsync(resourceGroupName, serviceName, aid, parameters, etag, CancellationToken.None);
        }
    }
}