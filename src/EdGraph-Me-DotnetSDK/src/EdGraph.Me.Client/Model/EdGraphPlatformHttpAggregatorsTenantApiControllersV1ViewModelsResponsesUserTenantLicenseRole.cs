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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.UserTenantLicenseRole")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole : IEquatable<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole" /> class.
        /// </summary>
        /// <param name="role">role.</param>
        /// <param name="isImplicitlyAssigned">isImplicitlyAssigned.</param>
        /// <param name="status">status.</param>
        /// <param name="educationOrganizationId">educationOrganizationId.</param>
        /// <param name="staffClassification">staffClassification.</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole(string role = default(string), bool isImplicitlyAssigned = default(bool), string status = default(string), int? educationOrganizationId = default(int?), string staffClassification = default(string))
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
        public bool IsImplicitlyAssigned { get; set; }

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
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole);
        }

        /// <summary>
        /// Returns true if EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserTenantLicenseRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.IsImplicitlyAssigned == input.IsImplicitlyAssigned ||
                    this.IsImplicitlyAssigned.Equals(input.IsImplicitlyAssigned)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.StaffClassification == input.StaffClassification ||
                    (this.StaffClassification != null &&
                    this.StaffClassification.Equals(input.StaffClassification))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsImplicitlyAssigned.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.EducationOrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                }
                if (this.StaffClassification != null)
                {
                    hashCode = (hashCode * 59) + this.StaffClassification.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
