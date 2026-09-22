
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request a response from the Live session’s Responses backend, or continue a delegated response waiting for tool results. Requires Responses delegation.<br/>
    /// Example: {"type":"response.create","event_id":"evt_response_001"}
    /// </summary>
    public sealed partial class LiveResponseCreateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `response.create`.<br/>
        /// Default Value: response.create
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveResponseCreateParamType.ResponseCreate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveResponseCreateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveResponseCreateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveResponseCreateParamType.ResponseCreate;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseCreateParam" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `response.create`.<br/>
        /// Default Value: response.create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponseCreateParam(
            string? eventId,
            global::tryAGI.OpenAI.LiveResponseCreateParamType type = global::tryAGI.OpenAI.LiveResponseCreateParamType.ResponseCreate)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseCreateParam" /> class.
        /// </summary>
        public LiveResponseCreateParam()
        {
        }

    }
}