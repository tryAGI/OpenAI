
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an error occurs.
    /// </summary>
    public sealed partial class ResponseErrorEvent
    {
        /// <summary>
        /// The type of the event. Always `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseErrorEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseErrorEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `error`.
        /// </param>
        /// <param name="code"></param>
        /// <param name="param"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseErrorEvent(
            string message,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseErrorEventType type,
            string? code,
            string? param)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        public ResponseErrorEvent()
        {
        }
    }
}