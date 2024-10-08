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
    /// IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfileTypesUserTenantLicenseRoleProfile
    /// </summary>
    [DataContract(Name = "IdentityApi.User.V1.UserTenantProfile+Types+UserTenantLicenseProfile+Types+UserTenantLicenseRoleProfile")]
    public partial class IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfileTypesUserTenantLicenseRoleProfile : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfileTypesUserTenantLicenseRoleProfile" /> class.
        /// </summary>
        /// <param name="role">role.</param>
        /// <param name="isImplicitlyAssigned">isImplicitlyAssigned.</param>
        /// <param name="status">status.</param>
        /// <param name="educationOrganizationId">educationOrganizationId.</param>
        /// <param name="staffClassification">staffClassification.</param>
        public IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfileTypesUserTenantLicenseRoleProfile(string role = default(string), bool? isImplicitlyAssigned = default(bool?), string status = default(string), int? educationOrganizationId = default(int?), string staffClassification = default(string))
        {
            this.Role = role;
            this.IsImplicitlyAssigned = isImplicitlyAssigned;
            this.Status = status;
            this.EducationOrganizationId = educationOrganizationId;
            this.StaffClassification = staffClassification;
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets IsImplicitlyAssigned
        /// </summary>
        [DataMember(Name = "isImplicitlyAssigned", EmitDefaultValue = true)]
        public bool? IsImplicitlyAssigned { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationId
        /// </summary>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = true)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets StaffClassification
        /// </summary>
        [DataMember(Name = "staffClassification", EmitDefaultValue = true)]
        public string StaffClassification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityApiUserV1UserTenantProfileTypesUserTenantLicenseProfileTypesUserTenantLicenseRoleProfile {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  IsImplicitlyAssigned: ").Append(IsImplicitlyAssigned).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  StaffClassification: ").Append(StaffClassification).Append("\n");
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
