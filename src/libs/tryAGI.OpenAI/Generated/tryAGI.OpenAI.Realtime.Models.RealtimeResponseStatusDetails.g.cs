
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Additional details about the status.
    /// </summary>
    public sealed partial class RealtimeResponseStatusDetails
    {
        /// <summary>
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
        /// `failed`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsType? Type { get; set; }

        /// <summary>
        /// The reason the Response did not complete. For a `cancelled` Response,  one of `turn_detected` (the server VAD detected a new start of speech)  or `client_cancelled` (the client sent a cancel event). For an  `incomplete` Response, one of `max_output_tokens` or `content_filter`  (the server-side safety filter activated and cut off the response).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsReasonJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsReason? Reason { get; set; }

        /// <summary>
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
        /// `failed`).
        /// </param>
        /// <param name="reason">
        /// The reason the Response did not complete. For a `cancelled` Response,  one of `turn_detected` (the server VAD detected a new start of speech)  or `client_cancelled` (the client sent a cancel event). For an  `incomplete` Response, one of `max_output_tokens` or `content_filter`  (the server-side safety filter activated and cut off the response).
        /// </param>
        /// <param name="error">
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseStatusDetails(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsType? type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsReason? reason,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsError? error)
        {
            this.Type = type;
            this.Reason = reason;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetails" /> class.
        /// </summary>
        public RealtimeResponseStatusDetails()
        {
        }
    }
}