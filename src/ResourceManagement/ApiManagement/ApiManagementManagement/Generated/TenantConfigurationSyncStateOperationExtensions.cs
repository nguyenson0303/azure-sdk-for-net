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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public static partial class TenantConfigurationSyncStateOperationExtensions
    {
        /// <summary>
        /// Gets Tenant Configuration Synchronization State operation result.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantConfigurationSyncStateOperation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// Get Tenant Configuration Synchronization State response details.
        /// </returns>
        public static TenantConfigurationSyncStateResponse Get(this ITenantConfigurationSyncStateOperation operations, string resourceGroupName, string serviceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITenantConfigurationSyncStateOperation)s).GetAsync(resourceGroupName, serviceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets Tenant Configuration Synchronization State operation result.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantConfigurationSyncStateOperation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// Get Tenant Configuration Synchronization State response details.
        /// </returns>
        public static Task<TenantConfigurationSyncStateResponse> GetAsync(this ITenantConfigurationSyncStateOperation operations, string resourceGroupName, string serviceName)
        {
            return operations.GetAsync(resourceGroupName, serviceName, CancellationToken.None);
        }
    }
}