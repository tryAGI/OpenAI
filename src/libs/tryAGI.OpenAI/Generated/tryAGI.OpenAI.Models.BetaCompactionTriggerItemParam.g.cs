
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Compacts the current context. Must be the final input item.
    /// </summary>
    public sealed partial class BetaCompactionTriggerItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `compaction_trigger`.<br/>
        /// Default Value: compaction_trigger
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType.CompactionTrigger</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCompactionTriggerItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType.CompactionTrigger;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionTriggerItemParam" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="type">
        /// The type of the item. Always `compaction_trigger`.<br/>
        /// Default Value: compaction_trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionTriggerItemParam(
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType type = global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType.CompactionTrigger)
        {
            this.Agent = agent;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionTriggerItemParam" /> class.
        /// </summary>
        public BetaCompactionTriggerItemParam()
        {
        }

    }
}