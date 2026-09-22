
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A configuration update that applies to subsequent responses until it is<br/>
    /// replaced by another configuration update.
    /// </summary>
    public sealed partial class BetaResponseConfigurationUpdate
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

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
        /// <default>global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType.ConfigurationUpdate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType Type { get; set; } = global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType.ConfigurationUpdate;

        /// <summary>
        /// The reasoning configuration applied by this update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the configuration update item.<br/>
        /// Example: cnfu_123
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
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
        public BetaResponseConfigurationUpdate(
            string id,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? reasoning,
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType type = global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType.ConfigurationUpdate)
        {
            this.Agent = agent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdate" /> class.
        /// </summary>
        public BetaResponseConfigurationUpdate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseConfigurationUpdate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseConfigurationUpdate FromId(string id)
        {
            return new BetaResponseConfigurationUpdate
            {
                Id = id,
            };
        }

    }
}