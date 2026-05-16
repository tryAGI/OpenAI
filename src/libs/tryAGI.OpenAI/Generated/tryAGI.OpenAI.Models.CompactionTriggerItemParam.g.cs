
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Compacts the current context. Must be the final input item.
    /// </summary>
    public sealed partial class CompactionTriggerItemParam
    {
        /// <summary>
        /// The type of the item. Always `compaction_trigger`.<br/>
        /// Default Value: compaction_trigger
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CompactionTriggerItemParamType.CompactionTrigger</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CompactionTriggerItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType Type { get; set; } = global::tryAGI.OpenAI.CompactionTriggerItemParamType.CompactionTrigger;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTriggerItemParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `compaction_trigger`.<br/>
        /// Default Value: compaction_trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionTriggerItemParam(
            global::tryAGI.OpenAI.CompactionTriggerItemParamType type = global::tryAGI.OpenAI.CompactionTriggerItemParamType.CompactionTrigger)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTriggerItemParam" /> class.
        /// </summary>
        public CompactionTriggerItemParam()
        {
        }

    }
}