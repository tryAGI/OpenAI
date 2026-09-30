
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionTurnTraceResource
    {
        /// <summary>
        /// The root turn ID. Use this ID as the pagination anchor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `agent.session.trace`.<br/>
        /// Default Value: agent.session.trace
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionTurnTraceResourceObject.AgentSessionTrace</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionTurnTraceResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject Object { get; set; } = global::tryAGI.OpenAI.SessionTurnTraceResourceObject.AgentSessionTrace;

        /// <summary>
        /// The session that owns this trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The Unix timestamp in seconds when the root turn was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// An OTLP JSON ExportTraceServiceRequest containing resourceSpans. Only currently published data is returned; later trace updates are not awaited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otlp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Otlp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTurnTraceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The root turn ID. Use this ID as the pagination anchor.
        /// </param>
        /// <param name="sessionId">
        /// The session that owns this trace.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp in seconds when the root turn was created.
        /// </param>
        /// <param name="otlp">
        /// An OTLP JSON ExportTraceServiceRequest containing resourceSpans. Only currently published data is returned; later trace updates are not awaited.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `agent.session.trace`.<br/>
        /// Default Value: agent.session.trace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionTurnTraceResource(
            string id,
            string sessionId,
            global::System.DateTimeOffset createdAt,
            object otlp,
            global::tryAGI.OpenAI.SessionTurnTraceResourceObject @object = global::tryAGI.OpenAI.SessionTurnTraceResourceObject.AgentSessionTrace)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt;
            this.Otlp = otlp ?? throw new global::System.ArgumentNullException(nameof(otlp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTurnTraceResource" /> class.
        /// </summary>
        public SessionTurnTraceResource()
        {
        }

    }
}