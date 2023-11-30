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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.UserCacheTenantEducationOrganizationResponse")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse : IEquatable<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">educationOrganizationId.</param>
        /// <param name="shortNameOfInstitution">shortNameOfInstitution.</param>
        /// <param name="nameOfInstitution">nameOfInstitution.</param>
        /// <param name="staffClassifications">staffClassifications.</param>
        /// <param name="source">source.</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse(int educationOrganizationId = default(int), string shortNameOfInstitution = default(string), string nameOfInstitution = default(string), List<string> staffClassifications = default(List<string>), string source = default(string))
        {
            this.EducationOrganizationId = educationOrganizationId;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.NameOfInstitution = nameOfInstitution;
            this.StaffClassifications = staffClassifications;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets EducationOrganizationId
        /// </summary>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ShortNameOfInstitution
        /// </summary>
        [DataMember(Name = "shortNameOfInstitution", EmitDefaultValue = true)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// Gets or Sets NameOfInstitution
        /// </summary>
        [DataMember(Name = "nameOfInstitution", EmitDefaultValue = true)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// Gets or Sets StaffClassifications
        /// </summary>
        [DataMember(Name = "staffClassifications", EmitDefaultValue = true)]
        public List<string> StaffClassifications { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  StaffClassifications: ").Append(StaffClassifications).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse);
        }

        /// <summary>
        /// Returns true if EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserCacheTenantEducationOrganizationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.StaffClassifications == input.StaffClassifications ||
                    this.StaffClassifications != null &&
                    input.StaffClassifications != null &&
                    this.StaffClassifications.SequenceEqual(input.StaffClassifications)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.ShortNameOfInstitution != null)
                {
                    hashCode = (hashCode * 59) + this.ShortNameOfInstitution.GetHashCode();
                }
                if (this.NameOfInstitution != null)
                {
                    hashCode = (hashCode * 59) + this.NameOfInstitution.GetHashCode();
                }
                if (this.StaffClassifications != null)
                {
                    hashCode = (hashCode * 59) + this.StaffClassifications.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
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
