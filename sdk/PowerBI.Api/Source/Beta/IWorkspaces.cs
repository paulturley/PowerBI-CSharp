// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Workspaces operations.
    /// </summary>
    public partial interface IWorkspaces
    {
        /// <summary>
        /// Returns a list of workspaces for the specified collection
        /// </summary>
        /// <param name='workspaceCollectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ODataResponseListWorkspace>> GetWorkspacesByCollectionNameWithHttpMessagesAsync(string workspaceCollectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new workspace within a workspace collection
        /// </summary>
        /// <param name='workspaceCollectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Workspace>> PostWorkspaceWithHttpMessagesAsync(string workspaceCollectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
