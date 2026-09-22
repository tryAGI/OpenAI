
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An update to the conversation's response configuration. The configuration<br/>
    /// remains in effect for subsequent responses until it is replaced by another<br/>
    /// configuration update.
    /// </summary>
    public sealed partial class ResponseConfigurationUpdateItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `configuration_update`.<br/>
        /// Default Value: configuration_update
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType.ConfigurationUpdate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType Type { get; set; } = global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType.ConfigurationUpdate;

        /// <summary>
        /// Updates to reasoning configuration. Only effort is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reasoning">
        /// Updates to reasoning configuration. Only effort is supported.
        /// </param>
        /// <param name="type">
        /// The item type. Always `configuration_update`.<br/>
        /// Default Value: configuration_update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseConfigurationUpdateItemParam(
            string? id,
            global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? reasoning,
            global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType type = global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType.ConfigurationUpdate)
        {
            this.Id = id;
            this.Type = type;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParam" /> class.
        /// </summary>
        public ResponseConfigurationUpdateItemParam()
        {
        }

    }
}