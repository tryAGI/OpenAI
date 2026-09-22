
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Provide context the Live model can communicate to the user, optionally for an existing client delegation.<br/>
    /// Example: {"type":"session.commentary.append","event_id":"evt_commentary_001","delegation_id":"del_abc123","content":"There is an outdoor table for two at 7 PM. Ask whether to reserve it."}
    /// </summary>
    public sealed partial class LiveCommentaryAppendParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.commentary.append`.<br/>
        /// Default Value: session.commentary.append
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveCommentaryAppendParamType.SessionCommentaryAppend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveCommentaryAppendParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType Type { get; set; } = global::tryAGI.OpenAI.LiveCommentaryAppendParamType.SessionCommentaryAppend;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_id")]
        public string? DelegationId { get; set; }

        /// <summary>
        /// Speakable context for the Live model, limited to 500 tokens. Use this for a result the model should communicate; use session.thinking.append for silent context.
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
        /// Initializes a new instance of the <see cref="LiveCommentaryAppendParam" /> class.
        /// </summary>
        /// <param name="content">
        /// Speakable context for the Live model, limited to 500 tokens. Use this for a result the model should communicate; use session.thinking.append for silent context.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="delegationId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.commentary.append`.<br/>
        /// Default Value: session.commentary.append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCommentaryAppendParam(
            string content,
            string? eventId,
            string? delegationId,
            global::tryAGI.OpenAI.LiveCommentaryAppendParamType type = global::tryAGI.OpenAI.LiveCommentaryAppendParamType.SessionCommentaryAppend)
        {
            this.EventId = eventId;
            this.Type = type;
            this.DelegationId = delegationId;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCommentaryAppendParam" /> class.
        /// </summary>
        public LiveCommentaryAppendParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveCommentaryAppendParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveCommentaryAppendParam FromContent(string content)
        {
            return new LiveCommentaryAppendParam
            {
                Content = content,
            };
        }

    }
}