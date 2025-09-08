
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Additional details about the status.
    /// </summary>
    public sealed partial class RealtimeBetaResponseStatusDetails
    {
        /// <summary>
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Error { get; set; }

        /// <summary>
        /// The reason the Response did not complete. For a `cancelled` Response, <br/>
        /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
        /// or `client_cancelled` (the client sent a cancel event). For an <br/>
        /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
        /// (the server-side safety filter activated and cut off the response).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsReasonJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Reason { get; set; }

        /// <summary>
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
        /// `failed`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseStatusDetails" /> class.
        /// </summary>
        /// <param name="error">
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </param>
        /// <param name="reason">
        /// The reason the Response did not complete. For a `cancelled` Response, <br/>
        /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
        /// or `client_cancelled` (the client sent a cancel event). For an <br/>
        /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
        /// (the server-side safety filter activated and cut off the response).
        /// </param>
        /// <param name="type">
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
        /// `failed`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaResponseStatusDetails(
            global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? error,
            global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? reason,
            global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? type)
        {
            this.Error = error;
            this.Reason = reason;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseStatusDetails" /> class.
        /// </summary>
        public RealtimeBetaResponseStatusDetails()
        {
        }
    }
}