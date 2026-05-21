
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents the organization's data retention control setting.
    /// </summary>
    public sealed partial class OrganizationDataRetention
    {
        /// <summary>
        /// The object type, which is always `organization.data_retention`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationDataRetentionObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationDataRetentionObject Object { get; set; }

        /// <summary>
        /// The configured organization data retention type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationDataRetentionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OrganizationDataRetentionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDataRetention" /> class.
        /// </summary>
        /// <param name="type">
        /// The configured organization data retention type.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.data_retention`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationDataRetention(
            global::tryAGI.OpenAI.OrganizationDataRetentionType type,
            global::tryAGI.OpenAI.OrganizationDataRetentionObject @object)
        {
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDataRetention" /> class.
        /// </summary>
        public OrganizationDataRetention()
        {
        }

    }
}