
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An audio input to the model.
    /// </summary>
    public sealed partial class InputAudio
    {
        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The format of the audio data. Currently supported formats are `mp3` and<br/>
        /// `wav`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputAudioFormat Format { get; set; }

        /// <summary>
        /// The type of the input item. Always `input_audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="format">
        /// The format of the audio data. Currently supported formats are `mp3` and<br/>
        /// `wav`.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_audio`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudio(
            string data,
            global::tryAGI.OpenAI.InputAudioFormat format,
            global::tryAGI.OpenAI.InputAudioType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }
    }
}