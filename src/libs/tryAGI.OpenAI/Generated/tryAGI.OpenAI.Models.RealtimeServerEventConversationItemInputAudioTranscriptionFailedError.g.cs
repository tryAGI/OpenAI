
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the transcription error.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionFailedError
    {
        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter related to the error, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The type of error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailedError" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="param">
        /// Parameter related to the error, if any.
        /// </param>
        /// <param name="type">
        /// The type of error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailedError(
            string? code,
            string? message,
            string? param,
            string? type)
        {
            this.Code = code;
            this.Message = message;
            this.Param = param;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailedError" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailedError()
        {
        }
    }
}