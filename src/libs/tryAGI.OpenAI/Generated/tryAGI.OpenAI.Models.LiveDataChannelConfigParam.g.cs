
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control which Live events an untrusted WebRTC frontend can send and receive over its data channel. These restrictions do not apply to trusted sideband connections.
    /// </summary>
    public sealed partial class LiveDataChannelConfigParam
    {
        /// <summary>
        /// Client event types that the frontend data channel may send. Use 'all' to allow every client event; an empty array allows none. Omission preserves the existing allow-all behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_client_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? AllowedClientEvents { get; set; }

        /// <summary>
        /// Server events that may be sent to the frontend data channel. Use 'all' to allow every server event; an empty array allows none. Omission preserves the existing allow-all behavior. Responses events use an object with type 'response.event' and a response_event selector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_server_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? AllowedServerEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDataChannelConfigParam" /> class.
        /// </summary>
        /// <param name="allowedClientEvents">
        /// Client event types that the frontend data channel may send. Use 'all' to allow every client event; an empty array allows none. Omission preserves the existing allow-all behavior.
        /// </param>
        /// <param name="allowedServerEvents">
        /// Server events that may be sent to the frontend data channel. Use 'all' to allow every server event; an empty array allows none. Omission preserves the existing allow-all behavior. Responses events use an object with type 'response.event' and a response_event selector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDataChannelConfigParam(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? allowedClientEvents,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? allowedServerEvents)
        {
            this.AllowedClientEvents = allowedClientEvents;
            this.AllowedServerEvents = allowedServerEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDataChannelConfigParam" /> class.
        /// </summary>
        public LiveDataChannelConfigParam()
        {
        }

    }
}