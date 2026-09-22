
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Append instructions to the Live conversation while it is running, optionally associating them with an existing client delegation.<br/>
    /// Example: {"type":"session.instructions.append","event_id":"evt_instructions_001","delegation_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","content":"The caller prefers outdoor seating."}
    /// </summary>
    public sealed partial class LiveInstructionsAppendParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.instructions.append`.<br/>
        /// Default Value: session.instructions.append
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInstructionsAppendParamType.SessionInstructionsAppend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInstructionsAppendParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType Type { get; set; } = global::tryAGI.OpenAI.LiveInstructionsAppendParamType.SessionInstructionsAppend;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_id")]
        public string? DelegationId { get; set; }

        /// <summary>
        /// Instruction text to append, limited to 500 tokens. This is a plain string, not an array of content parts.
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
        /// Initializes a new instance of the <see cref="LiveInstructionsAppendParam" /> class.
        /// </summary>
        /// <param name="content">
        /// Instruction text to append, limited to 500 tokens. This is a plain string, not an array of content parts.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="delegationId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.instructions.append`.<br/>
        /// Default Value: session.instructions.append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInstructionsAppendParam(
            string content,
            string? eventId,
            string? delegationId,
            global::tryAGI.OpenAI.LiveInstructionsAppendParamType type = global::tryAGI.OpenAI.LiveInstructionsAppendParamType.SessionInstructionsAppend)
        {
            this.EventId = eventId;
            this.Type = type;
            this.DelegationId = delegationId;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInstructionsAppendParam" /> class.
        /// </summary>
        public LiveInstructionsAppendParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInstructionsAppendParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInstructionsAppendParam FromContent(string content)
        {
            return new LiveInstructionsAppendParam
            {
                Content = content,
            };
        }

    }
}