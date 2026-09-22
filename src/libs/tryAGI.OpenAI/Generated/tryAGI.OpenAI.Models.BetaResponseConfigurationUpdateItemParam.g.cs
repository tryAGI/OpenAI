
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An update to the conversation's response configuration. The configuration<br/>
    /// remains in effect for subsequent responses until it is replaced by another<br/>
    /// configuration update.
    /// </summary>
    public sealed partial class BetaResponseConfigurationUpdateItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `configuration_update`.<br/>
        /// Default Value: configuration_update
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType.ConfigurationUpdate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType.ConfigurationUpdate;

        /// <summary>
        /// Updates to reasoning configuration. Only effort is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParam" /> class.
        /// </summary>
        /// <param name="agent"></param>
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
        public BetaResponseConfigurationUpdateItemParam(
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? reasoning,
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType type = global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType.ConfigurationUpdate)
        {
            this.Agent = agent;
            this.Id = id;
            this.Type = type;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParam" /> class.
        /// </summary>
        public BetaResponseConfigurationUpdateItemParam()
        {
        }

    }
}