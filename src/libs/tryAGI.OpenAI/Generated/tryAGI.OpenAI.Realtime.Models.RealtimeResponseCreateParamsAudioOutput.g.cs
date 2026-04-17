
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResponseCreateParamsAudioOutput
    {
        /// <summary>
        /// The format of the output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, `shimmer`, `verse`,<br/>
        /// `marin`, and `cedar`. You may also provide a custom voice object with<br/>
        /// an `id`, for example `{ "id": "voice_1234" }`. Voice cannot be changed<br/>
        /// during the session once the model has responded with audio at least once.<br/>
        /// We recommend `marin` and `cedar` for best quality.<br/>
        /// Default Value: alloy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsAudioOutput" /> class.
        /// </summary>
        /// <param name="format">
        /// The format of the output audio.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, `shimmer`, `verse`,<br/>
        /// `marin`, and `cedar`. You may also provide a custom voice object with<br/>
        /// an `id`, for example `{ "id": "voice_1234" }`. Voice cannot be changed<br/>
        /// during the session once the model has responded with audio at least once.<br/>
        /// We recommend `marin` and `cedar` for best quality.<br/>
        /// Default Value: alloy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreateParamsAudioOutput(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoice? voice)
        {
            this.Format = format;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsAudioOutput" /> class.
        /// </summary>
        public RealtimeResponseCreateParamsAudioOutput()
        {
        }
    }
}