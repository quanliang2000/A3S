/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.2
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using za.co.grindrodbank.a3s.Attributes;
using Microsoft.AspNetCore.Authorization;
using za.co.grindrodbank.a3s.A3SApiResources;

namespace za.co.grindrodbank.a3s.AbstractApiControllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class ClientApiController : ControllerBase
    { 
        /// <summary>
        /// Get a client.
        /// </summary>
        /// <remarks>Get a client by its client Id.</remarks>
        /// <param name="clientId">client</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the client.</response>
        /// <response code="404">Client not found.</response>
        /// <response code="500">An unexpected error occurred</response>
        [HttpGet]
        [Route("/clients/{clientId}", Name = "GetClient")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Oauth2Client))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetClientAsync([FromRoute][Required]string clientId);

        /// <summary>
        /// Search for clients.
        /// </summary>
        /// <remarks>Search for clients.</remarks>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="filterName">A search query filter on the name of the client.</param>
        /// <param name="filterClientId">A search query filter on the client ID of the client.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append &#39;_desc&#39; after a field to indicate descending order.  Supported fields. &#39;name&#39;, &#39;clientId&#39;</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of clients.</response>
        /// <response code="404">Client list not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/clients", Name = "ListClients")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<Oauth2Client>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListClientsAsync([FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery][StringLength(255, MinimumLength=0)]string filterName, [FromQuery][StringLength(255, MinimumLength=0)]string filterClientId, [FromQuery]string orderBy);
    }
}
