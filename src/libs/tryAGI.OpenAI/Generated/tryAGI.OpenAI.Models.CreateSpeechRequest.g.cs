
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechRequest
    {
        /// <summary>
        /// One of the available [TTS models](/docs/models#tts): `tts-1` or `tts-1-hd`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?> Model { get; set; }

        /// <summary>
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The voice to use when generating the audio. Supported voices are `alloy`, `ash`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage` and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateSpeechRequestVoice Voice { get; set; }

        /// <summary>
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter))]
        public global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// One of the available [TTS models](/docs/models#tts): `tts-1` or `tts-1-hd`
        /// </param>
        /// <param name="input">
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. Supported voices are `alloy`, `ash`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage` and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechRequest(
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?> model,
            string input,
            global::tryAGI.OpenAI.CreateSpeechRequestVoice voice,
            global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? responseFormat,
            double? speed)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        public CreateSpeechRequest()
        {
        }
    }
}