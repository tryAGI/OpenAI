
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content part that is done.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseContentPartDonePart
    {
        /// <summary>
        /// Base64-encoded audio data (if type is "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The text content (if type is "text").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The transcript of the audio (if type is "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type ("text", "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDonePart" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio data (if type is "audio").
        /// </param>
        /// <param name="text">
        /// The text content (if type is "text").
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio (if type is "audio").
        /// </param>
        /// <param name="type">
        /// The content type ("text", "audio").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventResponseContentPartDonePart(
            string? audio,
            string? text,
            string? transcript,
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? type)
        {
            this.Audio = audio;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDonePart" /> class.
        /// </summary>
        public RealtimeServerEventResponseContentPartDonePart()
        {
        }
    }
}