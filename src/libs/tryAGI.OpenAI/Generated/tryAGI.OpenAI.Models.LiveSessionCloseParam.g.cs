
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request that the Live session close. The terminal `session.closed` event contains the close reason and final usage.<br/>
    /// Example: {"type":"session.close","event_id":"evt_close_001"}
    /// </summary>
    public sealed partial class LiveSessionCloseParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.close`.<br/>
        /// Default Value: session.close
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionCloseParamType.SessionClose</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionCloseParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionCloseParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionCloseParamType.SessionClose;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCloseParam" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.close`.<br/>
        /// Default Value: session.close
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionCloseParam(
            string? eventId,
            global::tryAGI.OpenAI.LiveSessionCloseParamType type = global::tryAGI.OpenAI.LiveSessionCloseParamType.SessionClose)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCloseParam" /> class.
        /// </summary>
        public LiveSessionCloseParam()
        {
        }

    }
}