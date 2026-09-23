
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Configuration for reasoning-capable Realtime models such as `gpt-realtime-2`.
    /// </summary>
    public sealed partial class RealtimeReasoning
    {
        /// <summary>
        /// Constrains effort on reasoning for reasoning-capable Realtime models such as<br/>
        /// `gpt-realtime-2`.<br/>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeReasoningEffortJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning-capable Realtime models such as<br/>
        /// `gpt-realtime-2`.<br/>
        /// Default Value: low
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeReasoning(
            global::tryAGI.OpenAI.Realtime.RealtimeReasoningEffort? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeReasoning" /> class.
        /// </summary>
        public RealtimeReasoning()
        {
        }

    }
}