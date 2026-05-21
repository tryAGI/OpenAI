
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for updating project data retention controls.
    /// </summary>
    public sealed partial class UpdateProjectDataRetentionBody
    {
        /// <summary>
        /// The desired project data retention type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UpdateProjectDataRetentionBodyRetentionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType RetentionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectDataRetentionBody" /> class.
        /// </summary>
        /// <param name="retentionType">
        /// The desired project data retention type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectDataRetentionBody(
            global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType retentionType)
        {
            this.RetentionType = retentionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectDataRetentionBody" /> class.
        /// </summary>
        public UpdateProjectDataRetentionBody()
        {
        }

    }
}