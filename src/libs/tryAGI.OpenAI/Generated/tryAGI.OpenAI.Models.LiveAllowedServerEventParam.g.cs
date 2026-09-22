
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Live server event selector for the WebRTC frontend data channel.<br/>
    /// Example: {"type":"session.started"}
    /// </summary>
    public sealed partial class LiveAllowedServerEventParam
    {
        /// <summary>
        /// The outer Live server event type. Use 'response.event' for Responses events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The nested Responses event type. Required when type is 'response.event'; forbidden for other event types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_event")]
        public string? ResponseEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveAllowedServerEventParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The outer Live server event type. Use 'response.event' for Responses events.
        /// </param>
        /// <param name="responseEvent">
        /// The nested Responses event type. Required when type is 'response.event'; forbidden for other event types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveAllowedServerEventParam(
            string type,
            string? responseEvent)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ResponseEvent = responseEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveAllowedServerEventParam" /> class.
        /// </summary>
        public LiveAllowedServerEventParam()
        {
        }

    }
}