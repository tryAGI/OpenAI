
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGAAudioOutput
    {
        /// <summary>
        /// The format of the output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Format { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Voice { get; set; }

        /// <summary>
        /// The speed of the model's spoken response as a multiple of the original speed.<br/>
        /// 1.0 is the default speed. 0.25 is the minimum speed. 1.5 is the maximum speed. This value can only be changed in between model turns, not while a response is in progress.<br/>
        /// This parameter is a post-processing adjustment to the audio after it is generated, it's<br/>
        /// also possible to prompt the model to speak faster or slower.<br/>
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
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioOutput" /> class.
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
        /// <param name="speed">
        /// The speed of the model's spoken response as a multiple of the original speed.<br/>
        /// 1.0 is the default speed. 0.25 is the minimum speed. 1.5 is the maximum speed. This value can only be changed in between model turns, not while a response is in progress.<br/>
        /// This parameter is a post-processing adjustment to the audio after it is generated, it's<br/>
        /// also possible to prompt the model to speak faster or slower.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGAAudioOutput(
            global::tryAGI.OpenAI.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? voice,
            double? speed)
        {
            this.Format = format;
            this.Voice = voice;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioOutput" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGAAudioOutput()
        {
        }
    }
}