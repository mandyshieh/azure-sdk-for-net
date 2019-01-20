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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class SubscriptionServicePrincipalOperationsExtensions
    {
        /// <summary>
        /// The Create Service principal operation adds a new service principal
        /// in the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Service Principal
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Create(this ISubscriptionServicePrincipalOperations operations, SubscriptionServicePrincipalCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionServicePrincipalOperations)s).CreateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Create Service principal operation adds a new service principal
        /// in the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Service Principal
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateAsync(this ISubscriptionServicePrincipalOperations operations, SubscriptionServicePrincipalCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Service Principal operation deletes the service
        /// principalwith specified servicePrincipalId, if it exists in the
        /// subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='servicePrincipalId'>
        /// Required. The Id of the service principal.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ISubscriptionServicePrincipalOperations operations, string servicePrincipalId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionServicePrincipalOperations)s).DeleteAsync(servicePrincipalId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete Service Principal operation deletes the service
        /// principalwith specified servicePrincipalId, if it exists in the
        /// subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='servicePrincipalId'>
        /// Required. The Id of the service principal.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ISubscriptionServicePrincipalOperations operations, string servicePrincipalId)
        {
            return operations.DeleteAsync(servicePrincipalId, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Service Principal operation retrieves the service
        /// principalwith the specified servicePrincipalId, if it exists in
        /// the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='servicePrincipalId'>
        /// Required. The Id of the service principal.
        /// </param>
        /// <returns>
        /// The Get Service Principal operation response.
        /// </returns>
        public static SubscriptionServicePrincipalGetResponse Get(this ISubscriptionServicePrincipalOperations operations, string servicePrincipalId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionServicePrincipalOperations)s).GetAsync(servicePrincipalId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Service Principal operation retrieves the service
        /// principalwith the specified servicePrincipalId, if it exists in
        /// the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <param name='servicePrincipalId'>
        /// Required. The Id of the service principal.
        /// </param>
        /// <returns>
        /// The Get Service Principal operation response.
        /// </returns>
        public static Task<SubscriptionServicePrincipalGetResponse> GetAsync(this ISubscriptionServicePrincipalOperations operations, string servicePrincipalId)
        {
            return operations.GetAsync(servicePrincipalId, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Service Principal operation retrieves all the service
        /// principalsexisting in the current subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <returns>
        /// The List Service Principal operation response.
        /// </returns>
        public static SubscriptionServicePrincipalListResponse List(this ISubscriptionServicePrincipalOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionServicePrincipalOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Service Principal operation retrieves all the service
        /// principalsexisting in the current subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionServicePrincipalOperations.
        /// </param>
        /// <returns>
        /// The List Service Principal operation response.
        /// </returns>
        public static Task<SubscriptionServicePrincipalListResponse> ListAsync(this ISubscriptionServicePrincipalOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}