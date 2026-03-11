
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for audio output. Required when audio output is requested with<br/>
    /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2Audio
    {
        /// <summary>
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `fable`, `nova`, `onyx`,<br/>
        /// `sage`, `shimmer`, `marin`, and `cedar`. You may also provide a<br/>
        /// custom voice object with an `id`, for example `{ "id": "voice_1234" }`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice Voice { get; set; } = default!;

        /// <summary>
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat Format { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `fable`, `nova`, `onyx`,<br/>
        /// `sage`, `shimmer`, `marin`, and `cedar`. You may also provide a<br/>
        /// custom voice object with an `id`, for example `{ "id": "voice_1234" }`.
        /// </param>
        /// <param name="format">
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2Audio(
            global::tryAGI.OpenAI.VoiceIdsOrCustomVoice voice,
            global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat format)
        {
            this.Voice = voice;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2Audio()
        {
        }
    }
}