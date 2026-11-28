
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
        /// <default>"organization.data_retention"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "organization.data_retention";

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
            string @object = "organization.data_retention")
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

        /// <summary>
        /// Creates a new <see cref="OrganizationDataRetention"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OrganizationDataRetention FromType(global::tryAGI.OpenAI.OrganizationDataRetentionType type)
        {
            return new OrganizationDataRetention
            {
                Type = type,
            };
        }

    }
}