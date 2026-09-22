
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Input audio received from the primary transport and reflected to a Live sideband connection before model-input muting.<br/>
    /// Example: {"type":"session.input_audio.append","audio":"AACAAIAAAIAAAP9/AIAAgA=="}
    /// </summary>
    public sealed partial class LiveInputAudioAppend
    {
        /// <summary>
        /// The event type, always `session.input_audio.append`.<br/>
        /// Default Value: session.input_audio.append
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioAppendType.SessionInputAudioAppend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioAppendTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioAppendType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioAppendType.SessionInputAudioAppend;

        /// <summary>
        /// Base64-encoded raw mono PCM16LE at 24 kHz received from the primary transport, reflected to the sideband before model-input muting. This server event uses the same audio key as the client command, but is not an acknowledgment of it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioAppend" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded raw mono PCM16LE at 24 kHz received from the primary transport, reflected to the sideband before model-input muting. This server event uses the same audio key as the client command, but is not an acknowledgment of it.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.input_audio.append`.<br/>
        /// Default Value: session.input_audio.append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioAppend(
            string audio,
            global::tryAGI.OpenAI.LiveInputAudioAppendType type = global::tryAGI.OpenAI.LiveInputAudioAppendType.SessionInputAudioAppend)
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioAppend" /> class.
        /// </summary>
        public LiveInputAudioAppend()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInputAudioAppend"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInputAudioAppend FromAudio(string audio)
        {
            return new LiveInputAudioAppend
            {
                Audio = audio,
            };
        }

    }
}