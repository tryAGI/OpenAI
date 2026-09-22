
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Provide silent reasoning or progress context to the Live model, optionally for an existing client delegation.<br/>
    /// Example: {"type":"session.thinking.append","event_id":"evt_thinking_001","delegation_id":"del_abc123","content":"Checking availability for two guests at 7 PM."}
    /// </summary>
    public sealed partial class LiveThinkingAppendParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.thinking.append`.<br/>
        /// Default Value: session.thinking.append
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveThinkingAppendParamType.SessionThinkingAppend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveThinkingAppendParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType Type { get; set; } = global::tryAGI.OpenAI.LiveThinkingAppendParamType.SessionThinkingAppend;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_id")]
        public string? DelegationId { get; set; }

        /// <summary>
        /// Silent reasoning or progress context, limited to 500 tokens. It does not directly request speech, but can influence later speech and is not a secrecy boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveThinkingAppendParam" /> class.
        /// </summary>
        /// <param name="content">
        /// Silent reasoning or progress context, limited to 500 tokens. It does not directly request speech, but can influence later speech and is not a secrecy boundary.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="delegationId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.thinking.append`.<br/>
        /// Default Value: session.thinking.append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveThinkingAppendParam(
            string content,
            string? eventId,
            string? delegationId,
            global::tryAGI.OpenAI.LiveThinkingAppendParamType type = global::tryAGI.OpenAI.LiveThinkingAppendParamType.SessionThinkingAppend)
        {
            this.EventId = eventId;
            this.Type = type;
            this.DelegationId = delegationId;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveThinkingAppendParam" /> class.
        /// </summary>
        public LiveThinkingAppendParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveThinkingAppendParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveThinkingAppendParam FromContent(string content)
        {
            return new LiveThinkingAppendParam
            {
                Content = content,
            };
        }

    }
}