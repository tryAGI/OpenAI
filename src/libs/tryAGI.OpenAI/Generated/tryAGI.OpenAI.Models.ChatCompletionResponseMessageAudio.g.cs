
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// If the audio output modality is requested, this object contains data<br/>
    /// about the audio response from the model. [Learn more](/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionResponseMessageAudio
    {
        /// <summary>
        /// Unique identifier for this audio response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when this audio response will<br/>
        /// no longer be accessible on the server for use in multi-turn<br/>
        /// conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// Base64 encoded audio bytes generated by the model, in the format<br/>
        /// specified in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Transcript of the audio generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAudio" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this audio response.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when this audio response will<br/>
        /// no longer be accessible on the server for use in multi-turn<br/>
        /// conversations.
        /// </param>
        /// <param name="data">
        /// Base64 encoded audio bytes generated by the model, in the format<br/>
        /// specified in the request.
        /// </param>
        /// <param name="transcript">
        /// Transcript of the audio generated by the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionResponseMessageAudio(
            string id,
            global::System.DateTimeOffset expiresAt,
            string data,
            string transcript)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ExpiresAt = expiresAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAudio" /> class.
        /// </summary>
        public ChatCompletionResponseMessageAudio()
        {
        }
    }
}