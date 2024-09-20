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
    /// IdentityApiUserV1UserTenantProfile
    /// </summary>
    [DataContract(Name = "IdentityApi.User.V1.UserTenantProfile")]
    public partial class IdentityApiUserV1UserTenantProfile : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TenantType
        /// </summary>
        [DataMember(Name = "tenantType", EmitDefaultValue = false)]
        public IdentityApiUserV1TenantType? TenantType { get; set; }

        /// <summary>
        /// Gets or Sets TenantStatus
        /// </summary>
        [DataMember(Name = "tenantStatus", EmitDefaultValue = false)]
        public IdentityApiUserV1TenantStatus? TenantStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiUserV1UserTenantProfile" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="tenantType">tenantType.</param>
        /// <param name="tenantStatus">tenantStatus.</param>
        /// <param name="organizationIdentifier">organizationIdentifier.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="state">state.</param>
        /// <param name="isDemo">isDemo.</param>
        public IdentityApiUserV1UserTenantProfile(string tenantId = default(string), IdentityApiUserV1TenantType? tenantType = default(IdentityApiUserV1TenantType?), IdentityApiUserV1TenantStatus? tenantStatus = default(IdentityApiUserV1TenantStatus?), string organizationIdentifier = default(string), string organizationName = default(string), string state = default(string), bool? isDemo = default(bool?))
        {
            this.TenantId = tenantId;
            this.TenantType = tenantType;
            this.TenantStatus = tenantStatus;
            this.OrganizationIdentifier = organizationIdentifier;
            this.OrganizationName = organizationName;
            this.State = state;
            this.IsDemo = isDemo;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationIdentifier
        /// </summary>
        [DataMember(Name = "organizationIdentifier", EmitDefaultValue = true)]
        public string OrganizationIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name = "organizationName", EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets IsDemo
        /// </summary>
        [DataMember(Name = "isDemo", EmitDefaultValue = true)]
        public bool? IsDemo { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizations
        /// </summary>
        [DataMember(Name = "educationOrganizations", EmitDefaultValue = true)]
        public List<IdentityApiUserV1UserTenantProfileTypesUserTenantEducationOrganizationProfile> EducationOrganizations { get; private set; }

        /// <summary>
        /// Returns false as EducationOrganizations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEducationOrganizations()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name = "licenses", EmitDefaultValue = true)]
        public List<IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfile> Licenses { get; private set; }

        /// <summary>
        /// Returns false as Licenses should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLicenses()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityApiUserV1UserTenantProfile {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TenantType: ").Append(TenantType).Append("\n");
            sb.Append("  TenantStatus: ").Append(TenantStatus).Append("\n");
            sb.Append("  OrganizationIdentifier: ").Append(OrganizationIdentifier).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  IsDemo: ").Append(IsDemo).Append("\n");
            sb.Append("  EducationOrganizations: ").Append(EducationOrganizations).Append("\n");
            sb.Append("  Licenses: ").Append(Licenses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}