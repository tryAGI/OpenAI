
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudioInputAudio
    {
        /// <summary>
        /// Base64 encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The format of the encoded audio data. Currently supports "wav" and "mp3".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudioInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoded audio data.
        /// </param>
        /// <param name="format">
        /// The format of the encoded audio data. Currently supports "wav" and "mp3".
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestMessageContentPartAudioInputAudio(
            string data,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudioInputAudio" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartAudioInputAudio()
        {
        }
    }
}