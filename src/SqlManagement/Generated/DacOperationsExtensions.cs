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
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// This is the main client class for interacting with the Azure SQL
    /// Database REST APIs.
    /// </summary>
    public static partial class DacOperationsExtensions
    {
        /// <summary>
        /// Exports an Azure SQL Database into a DACPAC file in Azure Blob
        /// Storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// database to export resides.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters needed to initiate the export request.
        /// </param>
        /// <returns>
        /// Represents the response that the service returns once an import or
        /// export operation has been initiated.
        /// </returns>
        public static DacImportExportResponse Export(this IDacOperations operations, string serverName, DacExportParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDacOperations)s).ExportAsync(serverName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Exports an Azure SQL Database into a DACPAC file in Azure Blob
        /// Storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// database to export resides.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters needed to initiate the export request.
        /// </param>
        /// <returns>
        /// Represents the response that the service returns once an import or
        /// export operation has been initiated.
        /// </returns>
        public static Task<DacImportExportResponse> ExportAsync(this IDacOperations operations, string serverName, DacExportParameters parameters)
        {
            return operations.ExportAsync(serverName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of the import or export operation in the specified
        /// server with the corresponding request ID.  The request ID is
        /// provided in the responses of the import or export operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the server in which the import or export
        /// operation is taking place.
        /// </param>
        /// <param name='fullyQualifiedServerName'>
        /// Required. The fully qualified domain name of the Azure SQL Database
        /// Server where the operation is taking place. Example:
        /// a9s7f7s9d3.database.windows.net
        /// </param>
        /// <param name='username'>
        /// Required. The administrator username for the Azure SQL Database
        /// Server.
        /// </param>
        /// <param name='password'>
        /// Required. The administrator password for the Azure SQL Database
        /// Server.
        /// </param>
        /// <param name='requestId'>
        /// Required. The request ID of the operation being queried.  The
        /// request ID is obtained from the responses of the import and export
        /// operations.
        /// </param>
        /// <returns>
        /// Represents a list of import or export status values returned from
        /// GetStatus.
        /// </returns>
        public static DacGetStatusResponse GetStatus(this IDacOperations operations, string serverName, string fullyQualifiedServerName, string username, string password, string requestId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDacOperations)s).GetStatusAsync(serverName, fullyQualifiedServerName, username, password, requestId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of the import or export operation in the specified
        /// server with the corresponding request ID.  The request ID is
        /// provided in the responses of the import or export operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the server in which the import or export
        /// operation is taking place.
        /// </param>
        /// <param name='fullyQualifiedServerName'>
        /// Required. The fully qualified domain name of the Azure SQL Database
        /// Server where the operation is taking place. Example:
        /// a9s7f7s9d3.database.windows.net
        /// </param>
        /// <param name='username'>
        /// Required. The administrator username for the Azure SQL Database
        /// Server.
        /// </param>
        /// <param name='password'>
        /// Required. The administrator password for the Azure SQL Database
        /// Server.
        /// </param>
        /// <param name='requestId'>
        /// Required. The request ID of the operation being queried.  The
        /// request ID is obtained from the responses of the import and export
        /// operations.
        /// </param>
        /// <returns>
        /// Represents a list of import or export status values returned from
        /// GetStatus.
        /// </returns>
        public static Task<DacGetStatusResponse> GetStatusAsync(this IDacOperations operations, string serverName, string fullyQualifiedServerName, string username, string password, string requestId)
        {
            return operations.GetStatusAsync(serverName, fullyQualifiedServerName, username, password, requestId, CancellationToken.None);
        }
        
        /// <summary>
        /// Initiates an Import of a DACPAC file from Azure Blob Storage into a
        /// Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server into which the
        /// database is being imported.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters needed to initiated the Import request.
        /// </param>
        /// <returns>
        /// Represents the response that the service returns once an import or
        /// export operation has been initiated.
        /// </returns>
        public static DacImportExportResponse Import(this IDacOperations operations, string serverName, DacImportParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDacOperations)s).ImportAsync(serverName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Initiates an Import of a DACPAC file from Azure Blob Storage into a
        /// Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDacOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server into which the
        /// database is being imported.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters needed to initiated the Import request.
        /// </param>
        /// <returns>
        /// Represents the response that the service returns once an import or
        /// export operation has been initiated.
        /// </returns>
        public static Task<DacImportExportResponse> ImportAsync(this IDacOperations operations, string serverName, DacImportParameters parameters)
        {
            return operations.ImportAsync(serverName, parameters, CancellationToken.None);
        }
    }
}
