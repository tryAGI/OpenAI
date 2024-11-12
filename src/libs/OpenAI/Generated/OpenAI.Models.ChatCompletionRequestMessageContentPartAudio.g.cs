
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Learn about [audio inputs](/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudio
    {
        /// <summary>
        /// The type of the content part. Always `input_audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeJsonConverter))]
        public global::OpenAI.ChatCompletionRequestMessageContentPartAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content part. Always `input_audio`.
        /// </param>
        /// <param name="inputAudio"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestMessageContentPartAudio(
            global::OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio inputAudio,
            global::OpenAI.ChatCompletionRequestMessageContentPartAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartAudio()
        {
        }
    }
}