/*
 * Me Api
 *
 * Me Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdGraph.Me.Client.Client.OpenAPIDateConverter;

namespace EdGraph.Me.Client.Model
{
    /// <summary>
    /// Defines IdentityApi.User.V1.TenantStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityApiUserV1TenantStatus
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for value: Inactive
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive
    }

}
