
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for updating organization data retention controls.
    /// </summary>
    public sealed partial class UpdateOrganizationDataRetentionBody
    {
        /// <summary>
        /// The desired organization data retention type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UpdateOrganizationDataRetentionBodyRetentionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType RetentionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationDataRetentionBody" /> class.
        /// </summary>
        /// <param name="retentionType">
        /// The desired organization data retention type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationDataRetentionBody(
            global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType retentionType)
        {
            this.RetentionType = retentionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationDataRetentionBody" /> class.
        /// </summary>
        public UpdateOrganizationDataRetentionBody()
        {
        }

    }
}