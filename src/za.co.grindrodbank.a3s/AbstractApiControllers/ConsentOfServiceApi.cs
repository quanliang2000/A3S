/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.0
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
using za.co.grindrodbank.a3s.Models;

namespace za.co.grindrodbank.a3s.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class ConsentOfServiceApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new consent of service entry.
        /// </summary>
        /// <remarks>Create a new consent of service entry.</remarks>
        /// <param name="consentOfServiceSubmit"></param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to create consent of service entries.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/consentOfService", Name = "CreateConsentOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(ConsentOfService))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateConsentOfServiceAsync([FromBody]ConsentOfServiceSubmit consentOfServiceSubmit);

        /// <summary>
        /// Delete a consent of service entry.
        /// </summary>
        /// <remarks>Deletes a consent of service entry from A3S.</remarks>
        /// <param name="consentOfServiceId">The UUID of the consent of service entry to delete.</param>
        /// <response code="204">No Content.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to delete consent of service entry.</response>
        /// <response code="404">Consent of service entry not found.</response>
        /// <response code="422">Consent of service entry cannot be deleted.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpDelete]
        [Route("/consentOfService/{consentOfServiceId}", Name = "DeleteConsentOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> DeleteConsentOfServiceAsync([FromRoute][Required]Guid consentOfServiceId);

        /// <summary>
        /// Get a consent of service entry.
        /// </summary>
        /// <remarks>Get a consent of service entry by its UUID.</remarks>
        /// <param name="consentOfServiceId">Consent of service entry</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the consent of service entry.</response>
        /// <response code="404">Consent of service entry not found.</response>
        /// <response code="500">An unexpected error occurred</response>
        [HttpGet]
        [Route("/consentOfService/{consentOfServiceId}", Name = "GetConsentOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(ConsentOfService))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetConsentOfServiceAsync([FromRoute][Required]Guid consentOfServiceId);

        /// <summary>
        /// Search for consent of service entries.
        /// </summary>
        /// <remarks>Search for consent of service entries.</remarks>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="includeRelations">Determines whether the related entities, such as teams and which users accepted the consent, are returned.</param>
        /// <param name="filterConsentName">A search query filter on the consent&#39;s name.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append &#39;_desc&#39; after a field to indicate descending order. Supported fields. &#39;agreementName&#39;.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of terms of service entries.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/consentOfService", Name = "ListConsentOfServices")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<ConsentOfServiceListItem>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListConsentOfServicesAsync([FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery]bool includeRelations, [FromQuery][StringLength(255, MinimumLength=0)]string filterConsentName, [FromQuery]string orderBy);
    }
}
