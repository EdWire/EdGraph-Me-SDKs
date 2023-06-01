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
    /// Defines TenantApi.Tenant.V1.TenantIdentityProviders
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TenantApiTenantV1TenantIdentityProviders
    {
        /// <summary>
        /// Enum Local for value: Local
        /// </summary>
        [EnumMember(Value = "Local")]
        Local = 1,

        /// <summary>
        /// Enum Aad for value: Aad
        /// </summary>
        [EnumMember(Value = "Aad")]
        Aad = 2,

        /// <summary>
        /// Enum Google for value: Google
        /// </summary>
        [EnumMember(Value = "Google")]
        Google = 3,

        /// <summary>
        /// Enum Adfs for value: Adfs
        /// </summary>
        [EnumMember(Value = "Adfs")]
        Adfs = 4

    }

}