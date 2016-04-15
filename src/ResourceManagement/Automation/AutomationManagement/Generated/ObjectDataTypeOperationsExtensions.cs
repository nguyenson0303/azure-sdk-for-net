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
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class ObjectDataTypeOperationsExtensions
    {
        /// <summary>
        /// Retrieve a list of fields of a given type identified by module
        /// name.  (see
        /// http://aka.ms/azureautomationsdk/objectdatatypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IObjectDataTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='moduleName'>
        /// Required. The name of module.
        /// </param>
        /// <param name='typeName'>
        /// Required. The name of type.
        /// </param>
        /// <returns>
        /// The response model for the list fields operation.
        /// </returns>
        public static TypeFieldListResponse ListFieldsByModuleAndType(this IObjectDataTypeOperations operations, string resourceGroupName, string automationAccount, string moduleName, string typeName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IObjectDataTypeOperations)s).ListFieldsByModuleAndTypeAsync(resourceGroupName, automationAccount, moduleName, typeName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of fields of a given type identified by module
        /// name.  (see
        /// http://aka.ms/azureautomationsdk/objectdatatypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IObjectDataTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='moduleName'>
        /// Required. The name of module.
        /// </param>
        /// <param name='typeName'>
        /// Required. The name of type.
        /// </param>
        /// <returns>
        /// The response model for the list fields operation.
        /// </returns>
        public static Task<TypeFieldListResponse> ListFieldsByModuleAndTypeAsync(this IObjectDataTypeOperations operations, string resourceGroupName, string automationAccount, string moduleName, string typeName)
        {
            return operations.ListFieldsByModuleAndTypeAsync(resourceGroupName, automationAccount, moduleName, typeName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of fields of a given type across all accessible
        /// modules.  (see
        /// http://aka.ms/azureautomationsdk/objectdatatypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IObjectDataTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='typeName'>
        /// Required. The name of type.
        /// </param>
        /// <returns>
        /// The response model for the list fields operation.
        /// </returns>
        public static TypeFieldListResponse ListFieldsType(this IObjectDataTypeOperations operations, string resourceGroupName, string automationAccount, string typeName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IObjectDataTypeOperations)s).ListFieldsTypeAsync(resourceGroupName, automationAccount, typeName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of fields of a given type across all accessible
        /// modules.  (see
        /// http://aka.ms/azureautomationsdk/objectdatatypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IObjectDataTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='typeName'>
        /// Required. The name of type.
        /// </param>
        /// <returns>
        /// The response model for the list fields operation.
        /// </returns>
        public static Task<TypeFieldListResponse> ListFieldsTypeAsync(this IObjectDataTypeOperations operations, string resourceGroupName, string automationAccount, string typeName)
        {
            return operations.ListFieldsTypeAsync(resourceGroupName, automationAccount, typeName, CancellationToken.None);
        }
    }
}
