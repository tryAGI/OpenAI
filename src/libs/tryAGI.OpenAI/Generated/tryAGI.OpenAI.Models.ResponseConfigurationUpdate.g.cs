
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A configuration update that applies to subsequent responses until it is<br/>
    /// replaced by another configuration update.
    /// </summary>
    public sealed partial class ResponseConfigurationUpdate
    {
        /// <summary>
        /// The unique ID of the configuration update item.<br/>
        /// Example: cnfu_123
        /// </summary>
        /// <example>cnfu_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The item type. Always `configuration_update`.<br/>
        /// Default Value: configuration_update
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseConfigurationUpdateType.ConfigurationUpdate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateType Type { get; set; } = global::tryAGI.OpenAI.ResponseConfigurationUpdateType.ConfigurationUpdate;

        /// <summary>
        /// The reasoning configuration applied by this update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the configuration update item.<br/>
        /// Example: cnfu_123
        /// </param>
        /// <param name="reasoning">
        /// The reasoning configuration applied by this update.
        /// </param>
        /// <param name="type">
        /// The item type. Always `configuration_update`.<br/>
        /// Default Value: configuration_update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseConfigurationUpdate(
            string id,
            global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? reasoning,
            global::tryAGI.OpenAI.ResponseConfigurationUpdateType type = global::tryAGI.OpenAI.ResponseConfigurationUpdateType.ConfigurationUpdate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdate" /> class.
        /// </summary>
        public ResponseConfigurationUpdate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseConfigurationUpdate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseConfigurationUpdate FromId(string id)
        {
            return new ResponseConfigurationUpdate
            {
                Id = id,
            };
        }

    }
}