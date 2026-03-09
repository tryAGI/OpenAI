
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to update the session’s default configuration.<br/>
    /// Example: {"event_id":"event_123","type":"session.update","session":{"modalities":["text","audio"],"instructions":"Your knowledge cutoff is 2023-10. You are a helpful assistant.","voice":"alloy","input_audio_format":"pcm16","output_audio_format":"pcm16","input_audio_transcription":{"enabled":true,"model":"whisper-1"},"turn_detection":{"type":"server_vad","threshold":0.5,"prefix_padding_ms":300,"silence_duration_ms":200},"tools":[{"type":"function","name":"get_weather","description":"Get the current weather for a location.","parameters":{"type":"object","properties":{"location":{"type":"string"}},"required":["location"]}}],"tool_choice":"auto","temperature":0.8,"max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}}
    /// </summary>
    public sealed partial class RealtimeSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_123
        /// </summary>
        /// <example>event_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "session.update".<br/>
        /// Example: session.update
        /// </summary>
        /// <example>session.update</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionUpdateType? Type { get; set; }

        /// <summary>
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::tryAGI.OpenAI.RealtimeSession? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_123
        /// </param>
        /// <param name="type">
        /// The event type, must be "session.update".<br/>
        /// Example: session.update
        /// </param>
        /// <param name="session">
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionUpdate(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeSessionUpdateType? type,
            global::tryAGI.OpenAI.RealtimeSession? session)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdate" /> class.
        /// </summary>
        public RealtimeSessionUpdate()
        {
        }
    }
}