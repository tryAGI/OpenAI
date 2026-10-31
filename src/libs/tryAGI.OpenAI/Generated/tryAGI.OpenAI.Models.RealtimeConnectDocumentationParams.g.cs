
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeConnectDocumentationParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Selects the session type. Set `transcription` and omit `model` for a transcription session. If omitted, the session type from a client secret applies when present; otherwise the intent is `realtime`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConnectDocumentationParamsIntentJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConnectDocumentationParamsIntent? Intent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConnectDocumentationParams" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="callId"></param>
        /// <param name="intent">
        /// Selects the session type. Set `transcription` and omit `model` for a transcription session. If omitted, the session type from a client secret applies when present; otherwise the intent is `realtime`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConnectDocumentationParams(
            string? model,
            string? callId,
            global::tryAGI.OpenAI.RealtimeConnectDocumentationParamsIntent? intent)
        {
            this.Model = model;
            this.CallId = callId;
            this.Intent = intent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConnectDocumentationParams" /> class.
        /// </summary>
        public RealtimeConnectDocumentationParams()
        {
        }

    }
}